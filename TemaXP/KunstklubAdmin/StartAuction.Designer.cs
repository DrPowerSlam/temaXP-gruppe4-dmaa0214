namespace KunstklubAdmin
{
    partial class StartAuction
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
            this.hjælpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.listItem = new System.Windows.Forms.ListView();
            this.StartAuctionPanel = new System.Windows.Forms.Panel();
            this.btnStartAuction = new System.Windows.Forms.Button();
            this.txtAuctionName = new System.Windows.Forms.TextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.lblBid = new System.Windows.Forms.Label();
            this.listBid = new System.Windows.Forms.ListView();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.lblLatestBid = new System.Windows.Forms.Label();
            this.lblDkk = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminTools = new System.Windows.Forms.Label();
            this.txtLatestBid = new System.Windows.Forms.TextBox();
            this.lblDkk2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.StartAuctionPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.centralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auktionToolStripMenuItem,
            this.medlemToolStripMenuItem,
            this.kunstværkerToolStripMenuItem,
            this.hjælpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 28);
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
            this.opretToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.opretToolStripMenuItem.Text = "Opret";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
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
            // hjælpToolStripMenuItem
            // 
            this.hjælpToolStripMenuItem.Name = "hjælpToolStripMenuItem";
            this.hjælpToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.hjælpToolStripMenuItem.Text = "Hjælp";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.listItem);
            this.leftPanel.Controls.Add(this.StartAuctionPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 28);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(10);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 538);
            this.leftPanel.TabIndex = 1;
            // 
            // listItem
            // 
            this.listItem.Location = new System.Drawing.Point(23, 118);
            this.listItem.Margin = new System.Windows.Forms.Padding(0);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(164, 357);
            this.listItem.TabIndex = 2;
            this.listItem.UseCompatibleStateImageBehavior = false;
            // 
            // StartAuctionPanel
            // 
            this.StartAuctionPanel.Controls.Add(this.btnStartAuction);
            this.StartAuctionPanel.Controls.Add(this.txtAuctionName);
            this.StartAuctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartAuctionPanel.Location = new System.Drawing.Point(0, 0);
            this.StartAuctionPanel.Name = "StartAuctionPanel";
            this.StartAuctionPanel.Size = new System.Drawing.Size(200, 100);
            this.StartAuctionPanel.TabIndex = 0;
            // 
            // btnStartAuction
            // 
            this.btnStartAuction.AutoSize = true;
            this.btnStartAuction.Location = new System.Drawing.Point(88, 63);
            this.btnStartAuction.Name = "btnStartAuction";
            this.btnStartAuction.Size = new System.Drawing.Size(99, 27);
            this.btnStartAuction.TabIndex = 1;
            this.btnStartAuction.Text = "Start Auktion";
            this.btnStartAuction.UseVisualStyleBackColor = true;
            // 
            // txtAuctionName
            // 
            this.txtAuctionName.Location = new System.Drawing.Point(13, 25);
            this.txtAuctionName.Name = "txtAuctionName";
            this.txtAuctionName.Size = new System.Drawing.Size(131, 22);
            this.txtAuctionName.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.lblBid);
            this.rightPanel.Controls.Add(this.listBid);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(947, 28);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 538);
            this.rightPanel.TabIndex = 2;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(22, 18);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(33, 17);
            this.lblBid.TabIndex = 1;
            this.lblBid.Text = "Bud";
            // 
            // listBid
            // 
            this.listBid.Location = new System.Drawing.Point(22, 41);
            this.listBid.Name = "listBid";
            this.listBid.Size = new System.Drawing.Size(166, 409);
            this.listBid.TabIndex = 0;
            this.listBid.UseCompatibleStateImageBehavior = false;
            // 
            // centralPanel
            // 
            this.centralPanel.Controls.Add(this.lblDkk2);
            this.centralPanel.Controls.Add(this.txtLatestBid);
            this.centralPanel.Controls.Add(this.lblLatestBid);
            this.centralPanel.Controls.Add(this.lblDkk);
            this.centralPanel.Controls.Add(this.textBox3);
            this.centralPanel.Controls.Add(this.lblMinPrice);
            this.centralPanel.Controls.Add(this.lblDescription);
            this.centralPanel.Controls.Add(this.textBox1);
            this.centralPanel.Controls.Add(this.lblArtist);
            this.centralPanel.Controls.Add(this.txtTitel);
            this.centralPanel.Controls.Add(this.lblTitel);
            this.centralPanel.Controls.Add(this.txtNumber);
            this.centralPanel.Controls.Add(this.lblNumber);
            this.centralPanel.Controls.Add(this.pictureBox1);
            this.centralPanel.Controls.Add(this.buttonPanel);
            this.centralPanel.Controls.Add(this.panel1);
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.Location = new System.Drawing.Point(200, 28);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(747, 538);
            this.centralPanel.TabIndex = 3;
            // 
            // lblLatestBid
            // 
            this.lblLatestBid.AutoSize = true;
            this.lblLatestBid.Location = new System.Drawing.Point(329, 326);
            this.lblLatestBid.Name = "lblLatestBid";
            this.lblLatestBid.Size = new System.Drawing.Size(88, 17);
            this.lblLatestBid.TabIndex = 17;
            this.lblLatestBid.Text = "Højeste bud:";
            // 
            // lblDkk
            // 
            this.lblDkk.AutoSize = true;
            this.lblDkk.Location = new System.Drawing.Point(507, 298);
            this.lblDkk.Name = "lblDkk";
            this.lblDkk.Size = new System.Drawing.Size(36, 17);
            this.lblDkk.TabIndex = 16;
            this.lblDkk.Text = "DKK";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(415, 295);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 22);
            this.textBox3.TabIndex = 15;
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Location = new System.Drawing.Point(329, 298);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(84, 17);
            this.lblMinPrice.TabIndex = 14;
            this.lblMinPrice.Text = "Mindstepris:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 383);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Beskrivelse:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(14, 352);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(69, 17);
            this.lblArtist.TabIndex = 10;
            this.lblArtist.Text = "Kunstner:";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(98, 321);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(184, 22);
            this.txtTitel.TabIndex = 9;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(14, 323);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(39, 17);
            this.lblTitel.TabIndex = 8;
            this.lblTitel.Text = "Titel:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(98, 293);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(14, 293);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(31, 17);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Nr.:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 281);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.btnStart);
            this.buttonPanel.Controls.Add(this.btnPause);
            this.buttonPanel.Controls.Add(this.btnStop);
            this.buttonPanel.Controls.Add(this.btnNext);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 438);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonPanel.Size = new System.Drawing.Size(547, 100);
            this.buttonPanel.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(469, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(388, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(307, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(226, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Næste";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblAdminTools);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(547, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 538);
            this.panel1.TabIndex = 1;
            // 
            // lblAdminTools
            // 
            this.lblAdminTools.AutoSize = true;
            this.lblAdminTools.Location = new System.Drawing.Point(4, 4);
            this.lblAdminTools.Name = "lblAdminTools";
            this.lblAdminTools.Size = new System.Drawing.Size(111, 17);
            this.lblAdminTools.TabIndex = 0;
            this.lblAdminTools.Text = "Admin værktøjer";
            // 
            // txtLatestBid
            // 
            this.txtLatestBid.Location = new System.Drawing.Point(415, 326);
            this.txtLatestBid.Name = "txtLatestBid";
            this.txtLatestBid.Size = new System.Drawing.Size(85, 22);
            this.txtLatestBid.TabIndex = 18;
            // 
            // lblDkk2
            // 
            this.lblDkk2.AutoSize = true;
            this.lblDkk2.Location = new System.Drawing.Point(508, 331);
            this.lblDkk2.Name = "lblDkk2";
            this.lblDkk2.Size = new System.Drawing.Size(36, 17);
            this.lblDkk2.TabIndex = 19;
            this.lblDkk2.Text = "DKK";
            // 
            // StartAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 566);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartAuction";
            this.Text = "Start Auktion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.StartAuctionPanel.ResumeLayout(false);
            this.StartAuctionPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.centralPanel.ResumeLayout(false);
            this.centralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem hjælpToolStripMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ListView listItem;
        private System.Windows.Forms.Panel StartAuctionPanel;
        private System.Windows.Forms.Button btnStartAuction;
        private System.Windows.Forms.TextBox txtAuctionName;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ListView listBid;
        private System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminTools;
        private System.Windows.Forms.Label lblLatestBid;
        private System.Windows.Forms.Label lblDkk;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblDkk2;
        private System.Windows.Forms.TextBox txtLatestBid;
    }
}