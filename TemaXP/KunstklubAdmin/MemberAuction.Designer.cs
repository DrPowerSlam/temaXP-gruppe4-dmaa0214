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
            this.MemberName = new System.Windows.Forms.Label();
            this.MemberEmail = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoPainting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 131);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // InfoPainting
            // 
            this.InfoPainting.AutoSize = true;
            this.InfoPainting.Location = new System.Drawing.Point(143, 196);
            this.InfoPainting.Name = "InfoPainting";
            this.InfoPainting.Size = new System.Drawing.Size(131, 13);
            this.InfoPainting.TabIndex = 5;
            this.InfoPainting.Text = "Information om Kunstværk";
            // 
            // MemberAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 457);
            this.Controls.Add(this.InfoPainting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MemberEmail);
            this.Controls.Add(this.MemberName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberAuction";
            this.Text = "UCN Kunst klub";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberAuction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.Label MemberEmail;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InfoPainting;
    }
}

