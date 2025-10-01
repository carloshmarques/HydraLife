namespace HydraLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCursor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.bootMessagesRtb = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label1.Location = new System.Drawing.Point(80, 157);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(900, 28);
            this.Label1.TabIndex = 4;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 1024);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnrestart);
            this.panel2.Controls.Add(this.btnEndSession);
            this.panel2.Controls.Add(this.btnCloseApp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(998, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 1024);
            this.panel2.TabIndex = 8;
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.ForeColor = System.Drawing.Color.Blue;
            this.btnrestart.Image = global::LifeCicles.Properties.Resources.reset;
            this.btnrestart.Location = new System.Drawing.Point(27, 848);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(47, 47);
            this.btnrestart.TabIndex = 4;
            this.btnrestart.UseVisualStyleBackColor = false;
            // 
            // btnEndSession
            // 
            this.btnEndSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndSession.BackColor = System.Drawing.Color.Transparent;
            this.btnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSession.ForeColor = System.Drawing.Color.Blue;
            this.btnEndSession.Image = global::LifeCicles.Properties.Resources.logout;
            this.btnEndSession.Location = new System.Drawing.Point(27, 788);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(47, 47);
            this.btnEndSession.TabIndex = 3;
            this.btnEndSession.UseVisualStyleBackColor = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.Blue;
            this.btnCloseApp.Image = global::LifeCicles.Properties.Resources.power_on;
            this.btnCloseApp.Location = new System.Drawing.Point(27, 910);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(47, 47);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(191, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(734, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTimer.Location = new System.Drawing.Point(81, 60);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 20);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(332, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 13;
            // 
            // lblCursor
            // 
            this.lblCursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCursor.AutoSize = true;
            this.lblCursor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursor.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCursor.Location = new System.Drawing.Point(905, 716);
            this.lblCursor.Name = "lblCursor";
            this.lblCursor.Size = new System.Drawing.Size(0, 20);
            this.lblCursor.TabIndex = 14;
            this.lblCursor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTimer);
            this.panel3.Location = new System.Drawing.Point(111, 815);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 209);
            this.panel3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(83, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIOS Boot Sequence:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.Image = global::LifeCicles.Properties.Resources.hydra;
            this.PictureBox2.Location = new System.Drawing.Point(415, 0);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(286, 295);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // bootMessagesRtb
            // 
            this.bootMessagesRtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bootMessagesRtb.BackColor = System.Drawing.Color.Black;
            this.bootMessagesRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bootMessagesRtb.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootMessagesRtb.ForeColor = System.Drawing.Color.Lime;
            this.bootMessagesRtb.Location = new System.Drawing.Point(185, 314);
            this.bootMessagesRtb.Name = "bootMessagesRtb";
            this.bootMessagesRtb.ReadOnly = true;
            this.bootMessagesRtb.Size = new System.Drawing.Size(731, 481);
            this.bootMessagesRtb.TabIndex = 12;
            this.bootMessagesRtb.Text = "";
            this.bootMessagesRtb.TextChanged += new System.EventHandler(this.bootMessagesRtb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1093, 1024);
            this.Controls.Add(this.lblCursor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bootMessagesRtb);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Label lblCursor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox bootMessagesRtb;
    }
}

