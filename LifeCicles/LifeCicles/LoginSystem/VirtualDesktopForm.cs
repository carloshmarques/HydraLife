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
namespace LifeCicles.LoginSystem
{
    /// <summary>
    /// Main desktop interface launched after successful login.
    /// </summary>
    /// 
    
    public partial class VirtualDesktopForm : Form
    {
        // Variáveis e métodos como MinimizeToTray, EnableDoubleBuffering, etc.


        #region Inicialização
        public VirtualDesktopForm()
        {
            InitializeComponent();
            this.Load += VirtualDesktopForm_Load;
            this.FormClosing += VirtualDesktopForm_FormClosing;
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
            // Certifica-te de que o panelTopBar já foi inicializado antes de chamar esta função
            if (panelTopBar == null)
            {
                MessageBox.Show("panelTopBar is not initialized.");
                return;
            }
            ToolStripTextBox spacer = new ToolStripTextBox();
            spacer.Width = this.Width - 150; // Calcula com base no tamanho da janela


            spacer.BorderStyle = BorderStyle.None;
            spacer.ReadOnly = true;
            spacer.BackColor = Color.FromArgb(30, 30, 30); // Ou qualquer tom que combine com o fundo


            spacer.Size = new Size(0, 0); // Opcional
            spacer.AutoSize = false;
            spacer.Width = 1000; // Empurra os itens para a direita
            menuStrip1.Items.Add(spacer);
            ToolStripButton btnTray = new ToolStripButton("—");
            btnTray.ToolTipText = "Minimizar para a bandeja";
            btnTray.Alignment = ToolStripItemAlignment.Right;

            // Minimiza para bandeja
            //btnTray.Click += (s, e) => MinimizeToTray();

            // OU: apenas minimizar sem esconder
            btnTray.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            menuStrip1.Items.Add(btnTray);


        }
        private void VirtualDesktopForm_Resize(object sender, EventArgs e)
        {
            panelTopBar.Width = this.Width;
            leftSideTaskBar.Width = this.Width;
            // Se quiseres que o menuStrip também se ajuste, podes adicionar:
            // menuStrip1.Width = this.Width;
        }

       




        private void VirtualDesktopForm_Load(object sender, EventArgs e)
        {
            // 🖥️ Form setup
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackgroundImage = null;
            this.BackColor = panelContent.BackColor;

            // 🎨 Background panel
            panelContent.Dock = DockStyle.Fill;

            panelContent.BackgroundImage = Properties.Resources.material;
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;
            panelContent.SendToBack();

            // 🧭 MenuStrip setup
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.AutoSize = false;
            menuStrip1.Height = 30; // Altura fixa
                                    // NÃO definir Width manualmente

            menuStrip1.BackColor = Color.FromArgb(128, 0, 0, 0); // Estilo translúcido
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Parent = this; // Coloca diretamente no Form

            menuStrip1.BringToFront();

            // 🧱 TopBar setup
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.AutoSize = false;
            panelTopBar.Height = 40; // Altura fixa
            panelTopBar.BackColor = Color.Transparent;
            panelTopBar.Parent = panelContent;

            panelTopBar.BackColor = Color.Transparent;
            panelTopBar.Parent = panelContent;

            // 🧩 Left sidebar
            leftSideTaskBar.Parent = panelContent;

            leftSideTaskBar.Size = new Size(111, 922);
            leftSideTaskBar.Location = new Point(0, panelTopBar.Bottom);
            leftSideTaskBar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            leftSideTaskBar.Dock = DockStyle.None;
            leftSideTaskBar.BackColor = Color.Transparent;
            
            // 👤 User icon and label
            leftSideTaskBar.Controls.Add(pictureBoxUser);
            leftSideTaskBar.Controls.Add(labelAdmin);
            pictureBoxUser.Location = new Point(10, 5);

            labelAdmin.Text = "admin";
            labelAdmin.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            labelAdmin.ForeColor = Color.White;
            labelAdmin.BackColor = Color.Transparent;
            labelAdmin.AutoSize = true;
            labelAdmin.Location = new Point(pictureBoxUser.Left, pictureBoxUser.Top + 100);

            // 🌫️ Fade-in effect
            fadeTimer = new Timer();
            fadeTimer.Interval = 30;
            fadeTimer.Tick += (a, b) =>
            {
                this.Opacity += 0.05;
                if (this.Opacity >= 1)
                    fadeTimer.Stop();
            };

            // 🛎️ System tray icon



            // 🧠 TopBar controls
            SetupTopBarControls();

            // 🧠 Resize logic (apenas se necessário)
            this.Resize += VirtualDesktopForm_Resize;
        }


         




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
