namespace QLSinhVienThucTap.GUI
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKihoanrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(111, 26);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKihoanrToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // tàiKihoanrToolStripMenuItem
            // 
            this.tàiKihoanrToolStripMenuItem.Name = "tàiKihoanrToolStripMenuItem";
            this.tàiKihoanrToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tàiKihoanrToolStripMenuItem.Text = "Tài khoản";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 446);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            // 
            // tsmAccount
            // 
            this.tsmAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccountProfile,
            this.tsmChangePassword,
            this.tsmLogout});
            this.tsmAccount.Name = "tsmAccount";
            this.tsmAccount.Size = new System.Drawing.Size(70, 20);
            this.tsmAccount.Text = "Tài khoản";
            // 
            // tsmAccountProfile
            // 
            this.tsmAccountProfile.Name = "tsmAccountProfile";
            this.tsmAccountProfile.Size = new System.Drawing.Size(171, 22);
            this.tsmAccountProfile.Text = "Thông tin cá nhân";
            this.tsmAccountProfile.Click += new System.EventHandler(this.tsmAccountProfile_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(171, 22);
            this.tsmChangePassword.Text = "Đổi mật khẩu";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(171, 22);
            this.tsmLogout.Text = "Đăng xuất";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKihoanrToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
    }
}