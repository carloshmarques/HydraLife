using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifeCicles.Modules.Functions;
namespace LifeCicles.LoginSystem
{
    /// <summary>
    /// Main desktop interface launched after successful login.
    /// </summary>
    /// 
    
    public partial class VirtualDesktopForm : Form
    {
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
        public VirtualDesktopForm()
        {
            this.DoubleBuffered = true;
            

            InitializeComponent();

            EnableDoubleBuffering(panelContent); // ← Isto funciona!

            this.Load += VirtualDesktopForm_Load;
            
            
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
        }

       

        private void VirtualDesktopForm_Load(object sender, EventArgs e)
        {
            this.Resize += VirtualDesktopForm_Resize;

            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackgroundImage = null; // Evita conflito com o Form
            


            this.BackColor = panelContent.BackColor; // Ou Color.Black, se quiseres neutralidade

            panelContent.BackgroundImage = Properties.Resources.material;
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;


            // Painel de fundo para slideshow
            panelContent.Dock = DockStyle.Fill;
          
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;
            panelContent.SendToBack();
            panelTopBar.BackColor = Color.Transparent;
            menuStrip1.BackColor = Color.Transparent;

            panelTopBar.Parent = panelContent;
            menuStrip1.Parent = panelContent;


            // MenuStrip e TopBar                   
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.Size = new Size(this.Width, 30);
 


            panelTopBar.Dock = DockStyle.None;
             panelTopBar.AutoSize = true;
            panelTopBar.Size = new Size(this.Width, 40);
            panelTopBar.Location = new Point(0, menuStrip1.Bottom);

            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Parent = panelContent; // Garante que herda o fundo visual

            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.AutoSize = true;
            menuStrip1.Location = new Point(this.ClientSize.Width - menuStrip1.Width - 10, 0);

           
            menuStrip1.BringToFront();



            menuStrip1.BackColor = panelContent.BackColor;




            // leftSideTaskBar e pictureBoxUser
            leftSideTaskBar.Size = new Size(111, 922);
            leftSideTaskBar.Location = new Point(0, panelTopBar.Bottom);
            leftSideTaskBar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            leftSideTaskBar.Dock = DockStyle.None;
       


            leftSideTaskBar.Controls.Add(pictureBoxUser);
            leftSideTaskBar.Controls.Add(labelAdmin);
            pictureBoxUser.Location = new Point(10, 5);
            
            
            leftSideTaskBar.BackColor = Color.Transparent;

            // leftSideTaskBar e pictureBoxUser
            labelAdmin.ForeColor = Color.White;
            labelAdmin.BackColor = Color.Transparent;

            labelAdmin.Text = "admin";   // Ou define no login

            labelAdmin.AutoSize = true;
            labelAdmin.Location = new Point(10, 100); // Ajusta conforme layout

            labelAdmin.Font = new Font("Segoe UI", 16, FontStyle.Bold); // Ou "Consolas" para estilo terminal
            labelAdmin.AutoSize = true;

            int offsetY = pictureBoxUser.Top + 100; // Ajusta conforme o corpo da imagem
            labelAdmin.Location = new Point(pictureBoxUser.Left, offsetY);








            SetupTopBarControls();

  
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
    }
}
