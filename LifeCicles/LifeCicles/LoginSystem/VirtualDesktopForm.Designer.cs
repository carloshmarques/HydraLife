namespace LifeCicles.LoginSystem
{
    partial class VirtualDesktopForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.pm = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftSideTaskBar = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelContent.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.leftSideTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.BackgroundImage = global::LifeCicles.Properties.Resources.material;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Controls.Add(this.Panel2);
            this.panelContent.Controls.Add(this.panel4);
            this.panelContent.Controls.Add(this.leftSideTaskBar);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.panelTopBar);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1920, 1055);
            this.panelContent.TabIndex = 6;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel2.Controls.Add(this.pm);
            this.Panel2.Controls.Add(this.time);
            this.Panel2.Location = new System.Drawing.Point(1533, 833);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(363, 115);
            this.Panel2.TabIndex = 5;
            // 
            // pm
            // 
            this.pm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pm.BackColor = System.Drawing.Color.Transparent;
            this.pm.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.pm.ForeColor = System.Drawing.Color.White;
            this.pm.Location = new System.Drawing.Point(278, 36);
            this.pm.Margin = new System.Windows.Forms.Padding(8);
            this.pm.Name = "pm";
            this.pm.Size = new System.Drawing.Size(85, 65);
            this.pm.TabIndex = 2;
            this.pm.Text = "PM";
            this.pm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Segoe UI", 45F);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(8, 10);
            this.time.Margin = new System.Windows.Forms.Padding(8);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(246, 95);
            this.time.TabIndex = 1;
            this.time.Text = "12:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1882, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 922);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conky";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // leftSideTaskBar
            // 
            this.leftSideTaskBar.Controls.Add(this.labelAdmin);
            this.leftSideTaskBar.Controls.Add(this.pictureBoxUser);
            this.leftSideTaskBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSideTaskBar.Location = new System.Drawing.Point(0, 60);
            this.leftSideTaskBar.Name = "leftSideTaskBar";
            this.leftSideTaskBar.Size = new System.Drawing.Size(111, 922);
            this.leftSideTaskBar.TabIndex = 3;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Location = new System.Drawing.Point(13, 109);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(87, 23);
            this.labelAdmin.TabIndex = 7;
            this.labelAdmin.Text = "username";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImage = global::LifeCicles.Properties.Resources.img;
            this.pictureBoxUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(111, 106);
            this.pictureBoxUser.TabIndex = 6;
            this.pictureBoxUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnEndSession);
            this.panel1.Controls.Add(this.btnCloseApp);
            this.panel1.Controls.Add(this.btnrestart);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 982);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 73);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Image = global::LifeCicles.Properties.Resources.End_messaging_session;
            this.button4.Location = new System.Drawing.Point(824, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 45);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnEndSession
            // 
            this.btnEndSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndSession.BackColor = System.Drawing.Color.Transparent;
            this.btnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSession.ForeColor = System.Drawing.Color.Blue;
            this.btnEndSession.Image = global::LifeCicles.Properties.Resources.End_messaging_session;
            this.btnEndSession.Location = new System.Drawing.Point(1758, 16);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(41, 45);
            this.btnEndSession.TabIndex = 6;
            this.btnEndSession.UseVisualStyleBackColor = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.Blue;
            this.btnCloseApp.Image = global::LifeCicles.Properties.Resources.power_button_off;
            this.btnCloseApp.Location = new System.Drawing.Point(1856, 16);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(40, 45);
            this.btnCloseApp.TabIndex = 5;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.ForeColor = System.Drawing.Color.Blue;
            this.btnrestart.Image = global::LifeCicles.Properties.Resources.System_reboot__1_;
            this.btnrestart.Location = new System.Drawing.Point(1804, 16);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(47, 45);
            this.btnrestart.TabIndex = 7;
            this.btnrestart.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBox1.Location = new System.Drawing.Point(-2, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(628, 45);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "path to home folder like git style";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.Controls.Add(this.menuStrip1);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1920, 60);
            this.panelTopBar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textTestToolStripMenuItem,
            this.roleToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textTestToolStripMenuItem
            // 
            this.textTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem});
            this.textTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTestToolStripMenuItem.Name = "textTestToolStripMenuItem";
            this.textTestToolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.textTestToolStripMenuItem.Text = "App Menu xfce sryle";
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.somethingToolStripMenuItem.Text = "something";
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.roleToolStripMenuItem.Text = "Role";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(138, 27);
            this.toolStripTextBox1.Text = "Text";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // VirtualDesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LifeCicles.Properties.Resources.material;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VirtualDesktopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirtualDesktopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VirtualDesktopForm_Load);
            this.panelContent.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.leftSideTaskBar.ResumeLayout(false);
            this.leftSideTaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftSideTaskBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.RichTextBox richTextBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label pm;
        internal System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button button4;
    }
}