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
        /// <summary>
        /// Initializes the login panel and attaches the Load event handler.
        /// </summary>


        public LoginPanel()
        {
            InitializeComponent();
            this.Load += LoginPanel_Load;

        }
        /// <summary>
        /// Called when the login panel is loaded.
        /// Ensures that the admin account exists.
        /// </summary>
        private void LoginPanel_Load(object sender, EventArgs e)
        {
            EnsureAdminAccountExists();
        }

        /// <summary>
        /// Called when the login panel is loaded.
        /// Ensures that the admin account exists.
        /// </summary>
        private void EnsureAdminAccountExists()
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            loginTerminal.AppendText($"[{timestamp}] [ INFO ] Checking for admin account...\n");

            bool adminExists = true; // Simulated for now
            if (!adminExists)
            {
                loginTerminal.AppendText($"[{timestamp}] [ WARN ] Admin account not found. Creating dummy...\n");
                // Future logic to create account
            }
        }

        /// <summary>
        /// Raised when login credentials are valid and access is granted.
        /// </summary>
        public event EventHandler LoginSuccess;

        /// <summary>
        /// Raised when login credentials are invalid or missing.
        /// </summary>

        public event EventHandler LoginFailure;

       
        /// Validates user credentials and triggers success or failure events.
        /// Called when the Login button is clicked.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = usernameeTxt.Text;
            string pass = passwordTxt.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                loginTerminal.AppendText($"[{timestamp}] [ WARN ] Username or password is blank\n");
                LoginFailure?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (user == "admin" && pass == "hydra")
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                loginTerminal.AppendText($"[{timestamp}] [ OK ] Credentials accepted: launching Hydra Desktop...\n");
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                loginTerminal.AppendText($"[{timestamp}] [ ERROR ] Invalid credentials\n");
                LoginFailure?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

