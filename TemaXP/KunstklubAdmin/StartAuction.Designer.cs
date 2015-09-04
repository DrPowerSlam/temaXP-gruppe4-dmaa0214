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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.lblItems = new System.Windows.Forms.Label();
            this.listItem = new System.Windows.Forms.ListView();
            this.StartAuctionPanel = new System.Windows.Forms.Panel();
            this.btnStartAuction = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.lblBid = new System.Windows.Forms.Label();
            this.listBid = new System.Windows.Forms.ListView();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.TimerPanel = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDkk2 = new System.Windows.Forms.Label();
            this.txtLatestBid = new System.Windows.Forms.TextBox();
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
            this.panelEditTimer = new System.Windows.Forms.Panel();
            this.comboBoxTimer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimerEdit = new System.Windows.Forms.Label();
            this.panelEditInterval = new System.Windows.Forms.Panel();
            this.OKInterval = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblAdminTools = new System.Windows.Forms.Label();
            this.lblAuctionName = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.StartAuctionPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.centralPanel.SuspendLayout();
            this.TimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEditTimer.SuspendLayout();
            this.panelEditInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.lblItems);
            this.leftPanel.Controls.Add(this.listItem);
            this.leftPanel.Controls.Add(this.StartAuctionPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(10);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 566);
            this.leftPanel.TabIndex = 1;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(13, 107);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(157, 17);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "Kunstværker til auktion:";
            // 
            // listItem
            // 
            this.listItem.Location = new System.Drawing.Point(23, 137);
            this.listItem.Margin = new System.Windows.Forms.Padding(0);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(164, 338);
            this.listItem.TabIndex = 2;
            this.listItem.UseCompatibleStateImageBehavior = false;
            // 
            // StartAuctionPanel
            // 
            this.StartAuctionPanel.Controls.Add(this.lblAuctionName);
            this.StartAuctionPanel.Controls.Add(this.btnStartAuction);
            this.StartAuctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartAuctionPanel.Location = new System.Drawing.Point(0, 0);
            this.StartAuctionPanel.Name = "StartAuctionPanel";
            this.StartAuctionPanel.Size = new System.Drawing.Size(200, 100);
            this.StartAuctionPanel.TabIndex = 0;
            // 
            // btnStartAuction
            // 
            this.btnStartAuction.AutoSize = true;
            this.btnStartAuction.Location = new System.Drawing.Point(45, 57);
            this.btnStartAuction.Name = "btnStartAuction";
            this.btnStartAuction.Size = new System.Drawing.Size(99, 27);
            this.btnStartAuction.TabIndex = 1;
            this.btnStartAuction.Text = "Start Auktion";
            this.btnStartAuction.UseVisualStyleBackColor = true;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.lblBid);
            this.rightPanel.Controls.Add(this.listBid);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(947, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 566);
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
            this.centralPanel.Controls.Add(this.txtInterval);
            this.centralPanel.Controls.Add(this.lblInterval);
            this.centralPanel.Controls.Add(this.TimerPanel);
            this.centralPanel.Controls.Add(this.txtDescription);
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
            this.centralPanel.Location = new System.Drawing.Point(200, 0);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(747, 566);
            this.centralPanel.TabIndex = 3;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(400, 137);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.ReadOnly = true;
            this.txtInterval.Size = new System.Drawing.Size(100, 22);
            this.txtInterval.TabIndex = 23;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(329, 142);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(58, 17);
            this.lblInterval.TabIndex = 22;
            this.lblInterval.Text = "Interval:";
            // 
            // TimerPanel
            // 
            this.TimerPanel.Controls.Add(this.lblTimer);
            this.TimerPanel.Location = new System.Drawing.Point(332, 6);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Size = new System.Drawing.Size(200, 100);
            this.TimerPanel.TabIndex = 21;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(4, 4);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(51, 17);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "timer...";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(98, 383);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(184, 49);
            this.txtDescription.TabIndex = 20;
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
            // txtLatestBid
            // 
            this.txtLatestBid.Location = new System.Drawing.Point(415, 326);
            this.txtLatestBid.Name = "txtLatestBid";
            this.txtLatestBid.ReadOnly = true;
            this.txtLatestBid.Size = new System.Drawing.Size(85, 22);
            this.txtLatestBid.TabIndex = 18;
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
            this.textBox3.ReadOnly = true;
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
            this.textBox1.ReadOnly = true;
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
            this.txtTitel.ReadOnly = true;
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
            this.txtNumber.ReadOnly = true;
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
            this.buttonPanel.Location = new System.Drawing.Point(0, 466);
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
            this.panel1.Controls.Add(this.panelEditTimer);
            this.panel1.Controls.Add(this.panelEditInterval);
            this.panel1.Controls.Add(this.lblAdminTools);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(547, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 566);
            this.panel1.TabIndex = 1;
            // 
            // panelEditTimer
            // 
            this.panelEditTimer.Controls.Add(this.comboBoxTimer);
            this.panelEditTimer.Controls.Add(this.button1);
            this.panelEditTimer.Controls.Add(this.lblTimerEdit);
            this.panelEditTimer.Location = new System.Drawing.Point(7, 31);
            this.panelEditTimer.Name = "panelEditTimer";
            this.panelEditTimer.Size = new System.Drawing.Size(174, 91);
            this.panelEditTimer.TabIndex = 26;
            // 
            // comboBoxTimer
            // 
            this.comboBoxTimer.FormattingEnabled = true;
            this.comboBoxTimer.Location = new System.Drawing.Point(59, 17);
            this.comboBoxTimer.Name = "comboBoxTimer";
            this.comboBoxTimer.Size = new System.Drawing.Size(109, 24);
            this.comboBoxTimer.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTimerEdit
            // 
            this.lblTimerEdit.AutoSize = true;
            this.lblTimerEdit.Location = new System.Drawing.Point(4, 24);
            this.lblTimerEdit.Name = "lblTimerEdit";
            this.lblTimerEdit.Size = new System.Drawing.Size(48, 17);
            this.lblTimerEdit.TabIndex = 22;
            this.lblTimerEdit.Text = "Timer:";
            // 
            // panelEditInterval
            // 
            this.panelEditInterval.Controls.Add(this.OKInterval);
            this.panelEditInterval.Controls.Add(this.label1);
            this.panelEditInterval.Controls.Add(this.textBox4);
            this.panelEditInterval.Location = new System.Drawing.Point(7, 140);
            this.panelEditInterval.Name = "panelEditInterval";
            this.panelEditInterval.Size = new System.Drawing.Size(174, 91);
            this.panelEditInterval.TabIndex = 25;
            // 
            // OKInterval
            // 
            this.OKInterval.Location = new System.Drawing.Point(97, 65);
            this.OKInterval.Name = "OKInterval";
            this.OKInterval.Size = new System.Drawing.Size(75, 23);
            this.OKInterval.TabIndex = 24;
            this.OKInterval.Text = "OK";
            this.OKInterval.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Interval:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 0;
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
            // lblAuctionName
            // 
            this.lblAuctionName.AutoSize = true;
            this.lblAuctionName.Location = new System.Drawing.Point(13, 17);
            this.lblAuctionName.Name = "lblAuctionName";
            this.lblAuctionName.Size = new System.Drawing.Size(92, 17);
            this.lblAuctionName.TabIndex = 2;
            this.lblAuctionName.Text = "Auktion Navn";
            // 
            // StartAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 566);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "StartAuction";
            this.Text = "Start Auktion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.StartAuctionPanel.ResumeLayout(false);
            this.StartAuctionPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.centralPanel.ResumeLayout(false);
            this.centralPanel.PerformLayout();
            this.TimerPanel.ResumeLayout(false);
            this.TimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEditTimer.ResumeLayout(false);
            this.panelEditTimer.PerformLayout();
            this.panelEditInterval.ResumeLayout(false);
            this.panelEditInterval.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ListView listItem;
        private System.Windows.Forms.Panel StartAuctionPanel;
        private System.Windows.Forms.Button btnStartAuction;
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
        private System.Windows.Forms.Panel TimerPanel;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Panel panelEditTimer;
        private System.Windows.Forms.ComboBox comboBoxTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTimerEdit;
        private System.Windows.Forms.Panel panelEditInterval;
        private System.Windows.Forms.Button OKInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblAuctionName;
    }
}