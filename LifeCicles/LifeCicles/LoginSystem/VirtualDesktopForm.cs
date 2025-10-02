using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeCicles.LoginSystem
{
    /// <summary>
    /// Main desktop interface launched after successful login.
    /// </summary>
    public partial class VirtualDesktopForm : Form
    {
        public VirtualDesktopForm()
        {
            InitializeComponent();
            this.Load += VirtualDesktopForm_Load;
        }

        private void VirtualDesktopForm_Load(object sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            //desktopTerminal.AppendText($"[{timestamp}] [ INIT ] Hydra Desktop loaded\n");

            // Future: Load modules, user session, and layout zones
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
            Application.Exit();
        }
    }
}
