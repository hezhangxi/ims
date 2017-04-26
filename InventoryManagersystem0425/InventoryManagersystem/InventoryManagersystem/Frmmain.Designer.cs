namespace InventoryManagersystem
{
    partial class Frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPanal = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ntyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tsPanal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.cntMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHome,
            this.tsChangeUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHome
            // 
            this.tsHome.Image = ((System.Drawing.Image)(resources.GetObject("tsHome.Image")));
            this.tsHome.Name = "tsHome";
            this.tsHome.Size = new System.Drawing.Size(60, 21);
            this.tsHome.Text = "收缩";
            this.tsHome.Click += new System.EventHandler(this.tsHome_Click);
            // 
            // tsChangeUser
            // 
            this.tsChangeUser.Image = ((System.Drawing.Image)(resources.GetObject("tsChangeUser.Image")));
            this.tsChangeUser.Name = "tsChangeUser";
            this.tsChangeUser.Size = new System.Drawing.Size(84, 21);
            this.tsChangeUser.Text = "切换用户";
            this.tsChangeUser.Click += new System.EventHandler(this.tsChangeUser_Click);
            // 
            // tsPanal
            // 
            this.tsPanal.Controls.Add(this.treeView1);
            this.tsPanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanal.Location = new System.Drawing.Point(0, 25);
            this.tsPanal.Name = "tsPanal";
            this.tsPanal.Size = new System.Drawing.Size(185, 574);
            this.tsPanal.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(185, 574);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(185, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(681, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(185, 25);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(681, 552);
            this.MainTabControl.TabIndex = 3;
            this.MainTabControl.DoubleClick += new System.EventHandler(this.MainTabControl_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ntyIconMain
            // 
            this.ntyIconMain.ContextMenuStrip = this.cntMenuStripMain;
            this.ntyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("ntyIconMain.Icon")));
            this.ntyIconMain.Text = "3E-报表系统";
            this.ntyIconMain.Visible = true;
            // 
            // cntMenuStripMain
            // 
            this.cntMenuStripMain.BackColor = System.Drawing.Color.White;
            this.cntMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMax,
            this.tsHide,
            this.toolStripSeparator1,
            this.tsClose});
            this.cntMenuStripMain.Name = "contextMenuStrip1";
            this.cntMenuStripMain.Size = new System.Drawing.Size(101, 76);
            // 
            // tsMax
            // 
            this.tsMax.Image = ((System.Drawing.Image)(resources.GetObject("tsMax.Image")));
            this.tsMax.Name = "tsMax";
            this.tsMax.Size = new System.Drawing.Size(100, 22);
            this.tsMax.Text = "显示";
            this.tsMax.Click += new System.EventHandler(this.tsMax_Click);
            // 
            // tsHide
            // 
            this.tsHide.Image = ((System.Drawing.Image)(resources.GetObject("tsHide.Image")));
            this.tsHide.Name = "tsHide";
            this.tsHide.Size = new System.Drawing.Size(100, 22);
            this.tsHide.Text = "隐藏";
            this.tsHide.Click += new System.EventHandler(this.tsHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // tsClose
            // 
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(100, 22);
            this.tsClose.Text = "退出";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 599);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsPanal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmain";
            this.Text = "主页面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmmain_FormClosing);
            this.Load += new System.EventHandler(this.Frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsPanal.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.cntMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHome;
        private System.Windows.Forms.Panel tsPanal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NotifyIcon ntyIconMain;
        private System.Windows.Forms.ContextMenuStrip cntMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsMax;
        private System.Windows.Forms.ToolStripMenuItem tsHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsClose;
        private System.Windows.Forms.ToolStripMenuItem tsChangeUser;
    }
}