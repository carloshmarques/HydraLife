namespace LifeCicles.LoginSystem
{
    partial class LoginPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing" //true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.heraclito = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameeTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.lblLinkHelp = new System.Windows.Forms.LinkLabel();
            this.loginTerminal = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Location = new System.Drawing.Point(633, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // heraclito
            // 
            this.heraclito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heraclito.AutoSize = true;
            this.heraclito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heraclito.ForeColor = System.Drawing.Color.LimeGreen;
            this.heraclito.Location = new System.Drawing.Point(148, 73);
            this.heraclito.Name = "heraclito";
            this.heraclito.Size = new System.Drawing.Size(593, 23);
            this.heraclito.TabIndex = 0;
            this.heraclito.Text = "\"It\'s in changing that we find purpose.\" — Heraclitus";
            this.heraclito.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.usernameLbl.Location = new System.Drawing.Point(373, 159);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(80, 20);
            this.usernameLbl.TabIndex = 19;
            this.usernameLbl.Text = "Usename:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.passwordLbl.Location = new System.Drawing.Point(359, 199);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(94, 22);
            this.passwordLbl.TabIndex = 20;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameeTxt
            // 
            this.usernameeTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameeTxt.Location = new System.Drawing.Point(473, 155);
            this.usernameeTxt.Name = "usernameeTxt";
            this.usernameeTxt.Size = new System.Drawing.Size(257, 30);
            this.usernameeTxt.TabIndex = 21;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(473, 191);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(257, 30);
            this.passwordTxt.TabIndex = 22;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // lblLinkHelp
            // 
            this.lblLinkHelp.AutoSize = true;
            this.lblLinkHelp.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkHelp.Location = new System.Drawing.Point(642, 264);
            this.lblLinkHelp.Name = "lblLinkHelp";
            this.lblLinkHelp.Size = new System.Drawing.Size(88, 23);
            this.lblLinkHelp.TabIndex = 23;
            this.lblLinkHelp.TabStop = true;
            this.lblLinkHelp.Text = "Help me:";
            this.lblLinkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkHelp_LinkClicked);
            // 
            // loginTerminal
            // 
            this.loginTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTerminal.BackColor = System.Drawing.Color.Black;
            this.loginTerminal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTerminal.ForeColor = System.Drawing.Color.LimeGreen;
            this.loginTerminal.Location = new System.Drawing.Point(127, 301);
            this.loginTerminal.Name = "loginTerminal";
            this.loginTerminal.Size = new System.Drawing.Size(603, 96);
            this.loginTerminal.TabIndex = 24;
            this.loginTerminal.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(753, 380);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "label1";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.loginTerminal);
            this.Controls.Add(this.lblLinkHelp);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameeTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.heraclito);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(891, 473);
            this.Load += new System.EventHandler(this.LoginPanel_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label heraclito;  // to not touch and kali linux like "the quiet you became, the better you ear", just for visual kicks and thrills
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameeTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.LinkLabel lblLinkHelp;
        private System.Windows.Forms.RichTextBox loginTerminal;
        private System.Windows.Forms.Label lblStatus;
    }
}
