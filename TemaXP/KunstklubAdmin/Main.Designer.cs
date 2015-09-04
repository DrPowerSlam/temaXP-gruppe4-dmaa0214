namespace KunstklubAdmin
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.auktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kunstværkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auktionToolStripMenuItem,
            this.medlemToolStripMenuItem,
            this.kunstværkerToolStripMenuItem,
            this.omToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // auktionToolStripMenuItem
            // 
            this.auktionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opretToolStripMenuItem,
            this.startToolStripMenuItem,
            this.arkivToolStripMenuItem});
            this.auktionToolStripMenuItem.Name = "auktionToolStripMenuItem";
            this.auktionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.auktionToolStripMenuItem.Text = "Auktion";
            // 
            // opretToolStripMenuItem
            // 
            this.opretToolStripMenuItem.Name = "opretToolStripMenuItem";
            this.opretToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.opretToolStripMenuItem.Text = "Opret";
            this.opretToolStripMenuItem.Click += new System.EventHandler(this.opretToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // medlemToolStripMenuItem
            // 
            this.medlemToolStripMenuItem.Name = "medlemToolStripMenuItem";
            this.medlemToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.medlemToolStripMenuItem.Text = "Medlem";
            // 
            // kunstværkerToolStripMenuItem
            // 
            this.kunstværkerToolStripMenuItem.Name = "kunstværkerToolStripMenuItem";
            this.kunstværkerToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.kunstværkerToolStripMenuItem.Text = "Kunstværker";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.omToolStripMenuItem.Text = "Hjælp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem auktionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kunstværkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
    }
}

