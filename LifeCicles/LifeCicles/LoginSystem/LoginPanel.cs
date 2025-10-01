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
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Raised when login credentials are valid and access is granted.
        /// </summary>
        
        public event EventHandler LoginSuccess;

        /// <summary>
        /// Raised when login credentials are invalid or missing.
        /// </summary>
        public event EventHandler LoginFailure;

        /// <summary>
        /// Validates user credentials and triggers success or failure events.
        /// Called when the Login button is clicked.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = usernameeTxt.Text;
            string pass = passwordTxt.Text;

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
