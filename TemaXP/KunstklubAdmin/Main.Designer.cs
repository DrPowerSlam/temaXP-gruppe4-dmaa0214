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
            this.gåTilAuktionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
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
            this.auktionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.auktionToolStripMenuItem.Text = "Auktion";
            // 
            // opretToolStripMenuItem
            // 
            this.opretToolStripMenuItem.Name = "opretToolStripMenuItem";
            this.opretToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.opretToolStripMenuItem.Text = "Opret";
            this.opretToolStripMenuItem.Click += new System.EventHandler(this.opretToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // medlemToolStripMenuItem
            // 
            this.medlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gåTilAuktionToolStripMenuItem});
            this.medlemToolStripMenuItem.Name = "medlemToolStripMenuItem";
            this.medlemToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.medlemToolStripMenuItem.Text = "Medlem";
            // 
            // gåTilAuktionToolStripMenuItem
            // 
            this.gåTilAuktionToolStripMenuItem.Name = "gåTilAuktionToolStripMenuItem";
            this.gåTilAuktionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gåTilAuktionToolStripMenuItem.Text = "Gå til auktion";
            this.gåTilAuktionToolStripMenuItem.Click += new System.EventHandler(this.gåTilAuktionToolStripMenuItem_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "Start";
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
        private System.Windows.Forms.ToolStripMenuItem gåTilAuktionToolStripMenuItem;
    }
}

