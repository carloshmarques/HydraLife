using LifeCicles.Modules.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LifeCicles.LoginSystem
{
    /// <summary>
    /// Main desktop interface launched after successful login.
    /// </summary>
    /// 
    
    public partial class VirtualDesktopForm : Form
    {
        // Variáveis e métodos como MinimizeToTray, EnableDoubleBuffering, etc.


        public class DimmedColorTable : ProfessionalColorTable
    {
            public override Color MenuBorder => Color.FromArgb(20, 25, 30);
            public override Color MenuItemBorder => Color.FromArgb(60, 80, 70);
           
            public override Color ToolStripDropDownBackground => Color.FromArgb(20, 25, 30);
            public override Color ImageMarginGradientBegin => Color.FromArgb(20, 25, 30);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(20, 25, 30);
            public override Color ImageMarginGradientEnd => Color.FromArgb(20, 25, 30);

            public override Color MenuItemSelected => Color.FromArgb(80, 120, 100); // Verde petróleo mais vivo

        }

        #region Inicialização
        public VirtualDesktopForm()
        {
            InitializeComponent();
            this.Load += VirtualDesktopForm_Load;
            this.FormClosing += VirtualDesktopForm_FormClosing;
        }
        // ✅ Métodos de ação ligados no Form_Load
        private void EndSession()
        {
            MessageBox.Show("Sessão encerrada com elegância.");
        }

        private void OpenTerminal()
        {
            MessageBox.Show("Terminal aberto.");
        }


        private void VirtualDesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fadeTimer = new Timer();
            fadeTimer.Interval = 30;
            fadeTimer.Tick += (s, args) =>
            {
                this.Opacity -= 0.05;
                if (this.Opacity <= 0)
                {
                    fadeTimer.Stop();

                    // ✅ Aqui é o lugar certo
                    if (trayIcon == null)
                    {
                        trayIcon = new NotifyIcon();
                        trayIcon.Icon = Icon.FromHandle(Properties.Resources.hydra.GetHicon());
                        trayIcon.Text = "HydraDesktop";
                        trayIcon.Visible = true;
                    }

                    trayIcon.BalloonTipText = "Encerrando HydraDesktop com elegância...";
                    trayIcon.ShowBalloonTip(1000);

                    trayIcon.Dispose();
                    this.Dispose();
                    Application.Exit();
                }
            };
            fadeTimer.Start();

            e.Cancel = true; // Cancela o encerramento até o fade terminar
        }
        #endregion

        private Timer fadeTimer;
        private NotifyIcon trayIcon;

        private void MinimizeToTray()
        {
            if (trayIcon == null)
            {
                trayIcon = new NotifyIcon();
                trayIcon.Icon = Icon.FromHandle(Properties.Resources.hydra.GetHicon());
                // Adiciona ícone aos recursos
                trayIcon.Text = "HydraDesktop";
                trayIcon.Visible = true;

                trayIcon.DoubleClick += (s, e) =>
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    trayIcon.Visible = false;
                };
            }

            this.Hide(); // Esconde a janela
        }


        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }


        private void SetupTopBarControls()
        {
            time.Text = DateTime.Now.ToString("HH:mm");
            pm.Text = DateTime.Now.ToString("tt");
            pm.ForeColor = Color.White;
            time.ForeColor = Color.White;
        }

        private void SetupPanelContent()
        {
            panelContent.Dock = DockStyle.Fill;
            panelContent.BackColor = Color.FromArgb(20, 20, 30); // fundo técnico
            panelContent.Padding = new Padding(10);
            panelContent.BringToFront();
        }
        private void SetupEventBindings()
        {
            btnCloseApp.Click += (s, e) => Application.Exit();
            btnrestart.Click += (s, e) => Application.Restart();
            btnEndSession.Click += (s, e) => EndSession();
        }
        private void SetupStyleModeLabel()
        {
            label1.Text = "Conky";
            label1.ForeColor = Color.Yellow;
        }
     
        private void SetupUserBadge()
        {
            PictureBox userPic = new PictureBox();
            userPic.Image = Properties.Resources.img;

            userPic.SizeMode = PictureBoxSizeMode.Zoom;
            userPic.Size = new Size(32, 32);
            userPic.BackColor = Color.Transparent;
            userPic.Location = new Point(10, 5);

            Label roleLabel = new Label();
            roleLabel.Text = "admin";
            roleLabel.ForeColor = Color.FromArgb(180, 255, 180);
            roleLabel.Font = new Font("Consolas", 9, FontStyle.Regular);
            roleLabel.BackColor = Color.Transparent;
            roleLabel.Location = new Point(50, 10);

            this.Controls.Add(userPic);
            this.Controls.Add(roleLabel);
        }
       


        private void VirtualDesktopForm_Resize(object sender, EventArgs e)
        {
          
        }
        private void VirtualDesktopForm_Load(object sender, EventArgs e)
        {

            SetupFormStyle();           // Estilo geral do formulário
            SetupBackground();          // Imagem de fundo e transparência
            SetupMenuStrip();           // Topo técnico com botão Terminal
            SetupSideBar();             // Branding lateral com HydraLogo
            SetupTopBarControls();      // Relógio, ícones de sistema
            SetupPanelContent();        // Painel central para módulos
            SetupEventBindings();       // Eventos de botões (Shutdown, Restart, Settings)
            SetupStyleModeLabel();      // Label decorativo com modo visual ativo
                                        // ✅ Aplicar suavidade visual após estilo
            EnableDoubleBuffering(panelContent);
            EnableDoubleBuffering(panelTopBar);
            EnableDoubleBuffering(panel1);

            
        }

        private void SetupSideBar()
        {
            pictureBoxUser.BackgroundImage = Properties.Resources.img;
            labelAdmin.Text = "username";
            labelAdmin.ForeColor = Color.White;
        }


        private void SetupMenuStrip()
        {
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.Clear();

            var terminalItem = new ToolStripMenuItem("Terminal");
            terminalItem.Click += (s, e) => OpenTerminal();

            var roleItem = new ToolStripMenuItem("Role");
            var inputBox = new ToolStripTextBox { Text = "Text" };

            menuStrip1.Items.Add(terminalItem);
            menuStrip1.Items.Add(roleItem);
            menuStrip1.Items.Add(inputBox);
        }


        private void LaunchTerminal()
        {
            // Placeholder técnico — substitui com lógica real depois
            MessageBox.Show("Terminal lançado (em construção)", "HydraDesktop", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }



    

        private void SetupFormStyle()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void SetupBackground()
        {
            this.BackgroundImage = Properties.Resources.material;
            this.panelContent.BackColor = Color.Transparent;
            this.panelContent.BackgroundImage = Properties.Resources.material;
            this.panelContent.BackgroundImageLayout = ImageLayout.Stretch;
        }


        #region Accidental  
        // toques duplos de mouse ckick
        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taskAppIconToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();   // configurei temporaminte botão de desligar para desligar o pc acidentalmente como ontem!
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {


        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            trayIcon?.Dispose(); // Remove o ícone da bandeja
            base.OnFormClosing(e);
        }
    }
}
#endregion