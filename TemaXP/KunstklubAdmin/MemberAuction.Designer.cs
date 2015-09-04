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
            this.medlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kunstværkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medlemToolStripMenuItem
            // 
            this.medlemToolStripMenuItem.Name = "medlemToolStripMenuItem";
            this.medlemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.medlemToolStripMenuItem.Text = "Medlem";
            // 
            // kunstværkerToolStripMenuItem
            // 
            this.kunstværkerToolStripMenuItem.Name = "kunstværkerToolStripMenuItem";
            this.kunstværkerToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.kunstværkerToolStripMenuItem.Text = "Kunstværker";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.omToolStripMenuItem.Text = "Hjælp";
            // 
            // auktionToolStripMenuItem
            // 
            this.auktionToolStripMenuItem.Name = "auktionToolStripMenuItem";
            this.auktionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.auktionToolStripMenuItem.Text = "Auktion";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 457);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem medlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kunstværkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auktionToolStripMenuItem;
    }
}

