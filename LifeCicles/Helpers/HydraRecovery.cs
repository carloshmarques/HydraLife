using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mail;
using System.Windows.Forms;

namespace LifeCicles.Helpers
{
    internal class HydraRecovery
    {
        public static void OnAppClose(RichTextBox terminal = null)
        {
            terminal?.AppendText("[HydraRecovery] Recursive analysis initiated...\n");

            string tempDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp", "unsaved");
            if (!Directory.Exists(tempDir))
            {
                Directory.CreateDirectory(tempDir);
                terminal?.AppendText($"[HydraRecovery] Created temp directory: {tempDir}\n");
            }

            // Backup de controles com dados
            foreach (Control ctrl in Application.OpenForms[0].Controls)
            {
                if (ctrl is TextBox tb && !string.IsNullOrWhiteSpace(tb.Text))
                {
                    File.WriteAllText(Path.Combine(tempDir, $"textbox_{tb.Name}.txt"), tb.Text);
                    terminal?.AppendText($"[HydraRecovery] Backup: {tb.Name}\n");
                }
                else if (ctrl is RichTextBox rtb && !string.IsNullOrWhiteSpace(rtb.Text))
                {
                    File.WriteAllText(Path.Combine(tempDir, $"richtextbox_{rtb.Name}.txt"), rtb.Text);
                    terminal?.AppendText($"[HydraRecovery] Backup: {rtb.Name}\n");
                }
            }

            // Gerar relatório técnico
            string reportPath = Path.Combine(tempDir, $"closure_report_{DateTime.Now:yyyyMMdd_HHmmss}.log");
            File.AppendAllText(reportPath, $"HydraRecovery Report\nDate: {DateTime.Now}\n");

            foreach (string file in Directory.GetFiles(tempDir))
            {
                File.AppendAllText(reportPath, $"- Saved: {Path.GetFileName(file)}\n");
            }

            terminal?.AppendText("[HydraRecovery] Closing sequence complete.\n");

            string recoveryReport = Path.Combine(tempDir, $"recovery_report_{DateTime.Now:yyyyMMdd_HHmmss}.log");
            File.AppendAllText(recoveryReport, $"HydraRecovery Reopen Log\nDate: {DateTime.Now}\nRestored files:\n");

            string[] backupFiles = Directory.GetFiles(tempDir);
            foreach (string file in backupFiles)
            {
                File.AppendAllText(recoveryReport, $"- {Path.GetFileName(file)}\n");
            }

            
            string reportsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");
            Directory.CreateDirectory(reportsDir);

            string[] legacyReports = Directory.GetFiles(tempDir, "*_report_*.log");
            foreach (string report in legacyReports)
            {
                string destination = Path.Combine(reportsDir, Path.GetFileName(report));
                File.Copy(report, destination, true);
                terminal?.AppendText($"[HydraRecovery] Archived: {Path.GetFileName(report)}\n");
            }
        }

        public static void OnAppStart(Form mainForm, RichTextBox terminal = null)
        {
            string tempDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp", "unsaved");
            if (!Directory.Exists(tempDir)) return;

            string[] backupFiles = Directory.GetFiles(tempDir);
            if (backupFiles.Length == 0) return;

            terminal?.AppendText("[HydraRecovery] Previous session detected.\n");

            foreach (string file in backupFiles)
            {
                string fileName = Path.GetFileName(file);
                string content = File.ReadAllText(file);

                foreach (Control ctrl in mainForm.Controls)
                {
                    if (ctrl is TextBox tb && fileName.Contains(tb.Name))
                    {
                        tb.Text = content;
                        terminal?.AppendText($"[HydraRecovery] Restored: {tb.Name}\n");
                    }
                    else if (ctrl is RichTextBox rtb && fileName.Contains(rtb.Name))
                    {
                        rtb.Text = content;
                        terminal?.AppendText($"[HydraRecovery] Restored: {rtb.Name}\n");
                    }
                }
            }

            // 🔹 Enviar relatório arquivado
            string reportsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");
            string[] archivedReports = Directory.GetFiles(reportsDir, "*closure_report_*.log");

            if (archivedReports.Length > 0)
            {
                string latestReport = archivedReports.OrderByDescending(f => f).First();

                MailMessage mail = new MailMessage("hydra@yourapp.com", "devmanager@yourdomain.com");
                mail.Subject = "HydraRecovery Closure Report";
                mail.Body = File.ReadAllText(latestReport);

                SmtpClient client = new SmtpClient("smtp.yourdomain.com");
                client.Send(mail);

                terminal?.AppendText($"[HydraRecovery] Closure report sent: {Path.GetFileName(latestReport)}\n");
            }

            // 🔹 Limpar backups após restauração
            Directory.Delete(tempDir, true);
            terminal?.AppendText("[HydraRecovery] Temporary backups cleared.\n");
        }

    }
}
