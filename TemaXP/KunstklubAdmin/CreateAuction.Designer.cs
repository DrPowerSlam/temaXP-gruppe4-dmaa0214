namespace KunstklubAdmin
{
    partial class CreateAuction
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
            this.medlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kunstværkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjælpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auktionToolStripMenuItem,
            this.medlemToolStripMenuItem,
            this.kunstværkToolStripMenuItem,
            this.hjælpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 28);
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
            // medlemToolStripMenuItem
            // 
            this.medlemToolStripMenuItem.Name = "medlemToolStripMenuItem";
            this.medlemToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.medlemToolStripMenuItem.Text = "Medlem";
            // 
            // kunstværkToolStripMenuItem
            // 
            this.kunstværkToolStripMenuItem.Name = "kunstværkToolStripMenuItem";
            this.kunstværkToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.kunstværkToolStripMenuItem.Text = "Kunstværk";
            // 
            // hjælpToolStripMenuItem
            // 
            this.hjælpToolStripMenuItem.Name = "hjælpToolStripMenuItem";
            this.hjælpToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.hjælpToolStripMenuItem.Text = "Hjælp";
            // 
            // opretToolStripMenuItem
            // 
            this.opretToolStripMenuItem.Name = "opretToolStripMenuItem";
            this.opretToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.opretToolStripMenuItem.Text = "Opret";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Opret";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateAuction";
            this.Text = "Opret Auktion";
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
        private System.Windows.Forms.ToolStripMenuItem kunstværkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjælpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}