using System;
using System.IO;
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
        }
    }
}
