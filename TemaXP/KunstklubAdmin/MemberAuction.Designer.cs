namespace KunstklubAdmin
{
    partial class MemberAuction
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
            this.MemberName = new System.Windows.Forms.Label();
            this.MemberEmail = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // MemberName
            // 
            this.MemberName.AutoSize = true;
            this.MemberName.Location = new System.Drawing.Point(12, 24);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(70, 13);
            this.MemberName.TabIndex = 1;
            this.MemberName.Text = "MedlemNavn";
            // 
            // MemberEmail
            // 
            this.MemberEmail.AutoSize = true;
            this.MemberEmail.Location = new System.Drawing.Point(88, 24);
            this.MemberEmail.Name = "MemberEmail";
            this.MemberEmail.Size = new System.Drawing.Size(32, 13);
            this.MemberEmail.TabIndex = 2;
            this.MemberEmail.Text = "Email";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(96, 383);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MemberAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 457);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MemberEmail);
            this.Controls.Add(this.MemberName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberAuction";
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
        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.Label MemberEmail;
        private System.Windows.Forms.ListView listView1;
    }
}

