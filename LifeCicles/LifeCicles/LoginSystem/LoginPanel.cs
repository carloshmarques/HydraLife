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
    /// Login panel responsible for validating user credentials and triggering login events.
    /// </summary>
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
            this.Load += LoginPanel_Load;
            lblLinkHelp.LinkClicked += lblLinkHelp_LinkClicked;
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            loginTerminal.Text = "path to where form is 'home', like git style"; // to be replaced with best logic here:....
            EnsureAdminAccountExists();
        }

        private void EnsureAdminAccountExists()
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            loginTerminal.AppendText($"[{timestamp}] [ INFO ] Checking for admin account...\n");

            bool adminExists = true; // Simulated for now
            if (!adminExists)
            {
                loginTerminal.AppendText($"[{timestamp}] [ WARN ] Admin account not found. Creating dummy...\n");
            }
        }

        public event EventHandler LoginSuccess;
        public event EventHandler LoginFailure;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = usernameeTxt.Text;
            string pass = passwordTxt.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                loginTerminal.AppendText($"[{timestamp}] [ WARN ] Username or password is blank\n");
                //SessionManager.LogFailure(user);
                LoginFailure?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (user == "admin" && pass == "hydra")
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                loginTerminal.AppendText($"[{timestamp}] [ OK ] Credentials accepted: launching Hydra Desktop...\n");
                //SessionManager.StartSession(user);
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                loginTerminal.AppendText($"[{timestamp}] [ ERROR ] Invalid credentials\n");
                //SessionManager.LogFailure(user);
                LoginFailure?.Invoke(this, EventArgs.Empty);
            }
        }

        private void lblLinkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            loginTerminal.AppendText($"[{timestamp}] [ HELP ] To log in, enter your username and password.\n");
            loginTerminal.AppendText($"[{timestamp}] [ HELP ] Default admin credentials: admin / hydra\n");
            loginTerminal.AppendText($"[{timestamp}] [ HELP ] Press Login to continue or contact support.\n");

            //Reporter.Report("help_request", "User clicked help link for login guidance", "LoginPanel");
        }

        private void LoginPanel_Load_1(object sender, EventArgs e)
        {

        }
    }



}

