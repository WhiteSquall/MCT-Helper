namespace MCT_Helper
{
    partial class fMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainMenu));
            this.nMainMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.nMainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bPCD = new System.Windows.Forms.ToolStripMenuItem();
            this.bTap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.bExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nMainMenu
            // 
            this.nMainMenu.ContextMenuStrip = this.nMainMenuStrip;
            resources.ApplyResources(this.nMainMenu, "nMainMenu");
            // 
            // nMainMenuStrip
            // 
            this.nMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bPCD,
            this.bTap,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.bExit});
            this.nMainMenuStrip.Name = "nMainMenuStrip";
            resources.ApplyResources(this.nMainMenuStrip, "nMainMenuStrip");
            // 
            // bPCD
            // 
            this.bPCD.Name = "bPCD";
            resources.ApplyResources(this.bPCD, "bPCD");
            this.bPCD.Click += new System.EventHandler(this.bPCD_Click);
            // 
            // bTap
            // 
            this.bTap.Name = "bTap";
            resources.ApplyResources(this.bTap, "bTap");
            this.bTap.Click += new System.EventHandler(this.bTap_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // bExit
            // 
            this.bExit.Name = "bExit";
            resources.ApplyResources(this.bExit, "bExit");
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // fMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMainMenu";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.nMainMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nMainMenu;
        private System.Windows.Forms.ContextMenuStrip nMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bPCD;
        private System.Windows.Forms.ToolStripMenuItem bTap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bExit;
    }
}

