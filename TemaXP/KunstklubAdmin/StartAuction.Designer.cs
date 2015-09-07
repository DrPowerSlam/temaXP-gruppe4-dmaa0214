﻿namespace KunstklubAdmin
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
            this.lblAuctionName = new System.Windows.Forms.Label();
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
            this.leftPanel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 561);
            this.leftPanel.TabIndex = 1;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(10, 87);
            this.lblItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(119, 13);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "Kunstværker til auktion:";
            // 
            // listItem
            // 
            this.listItem.Location = new System.Drawing.Point(17, 111);
            this.listItem.Margin = new System.Windows.Forms.Padding(0);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(124, 406);
            this.listItem.TabIndex = 2;
            this.listItem.UseCompatibleStateImageBehavior = false;
            // 
            // StartAuctionPanel
            // 
            this.StartAuctionPanel.Controls.Add(this.lblAuctionName);
            this.StartAuctionPanel.Controls.Add(this.btnStartAuction);
            this.StartAuctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartAuctionPanel.Location = new System.Drawing.Point(0, 0);
            this.StartAuctionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartAuctionPanel.Name = "StartAuctionPanel";
            this.StartAuctionPanel.Size = new System.Drawing.Size(150, 81);
            this.StartAuctionPanel.TabIndex = 0;
            // 
            // lblAuctionName
            // 
            this.lblAuctionName.AutoSize = true;
            this.lblAuctionName.Location = new System.Drawing.Point(10, 14);
            this.lblAuctionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuctionName.Name = "lblAuctionName";
            this.lblAuctionName.Size = new System.Drawing.Size(72, 13);
            this.lblAuctionName.TabIndex = 2;
            this.lblAuctionName.Text = "Auktion Navn";
            // 
            // btnStartAuction
            // 
            this.btnStartAuction.AutoSize = true;
            this.btnStartAuction.Location = new System.Drawing.Point(34, 46);
            this.btnStartAuction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartAuction.Name = "btnStartAuction";
            this.btnStartAuction.Size = new System.Drawing.Size(78, 23);
            this.btnStartAuction.TabIndex = 1;
            this.btnStartAuction.Text = "Start Auktion";
            this.btnStartAuction.UseVisualStyleBackColor = true;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.lblBid);
            this.rightPanel.Controls.Add(this.listBid);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(710, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(150, 561);
            this.rightPanel.TabIndex = 2;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(16, 15);
            this.lblBid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(26, 13);
            this.lblBid.TabIndex = 1;
            this.lblBid.Text = "Bud";
            // 
            // listBid
            // 
            this.listBid.Location = new System.Drawing.Point(16, 33);
            this.listBid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBid.Name = "listBid";
            this.listBid.Size = new System.Drawing.Size(126, 484);
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
            this.centralPanel.Location = new System.Drawing.Point(150, 0);
            this.centralPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(560, 561);
            this.centralPanel.TabIndex = 3;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(311, 357);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.ReadOnly = true;
            this.txtInterval.Size = new System.Drawing.Size(76, 20);
            this.txtInterval.TabIndex = 23;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(247, 361);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(45, 13);
            this.lblInterval.TabIndex = 22;
            this.lblInterval.Text = "Interval:";
            // 
            // TimerPanel
            // 
            this.TimerPanel.Controls.Add(this.lblTimer);
            this.TimerPanel.Location = new System.Drawing.Point(249, 5);
            this.TimerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Size = new System.Drawing.Size(150, 32);
            this.TimerPanel.TabIndex = 21;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(3, 3);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(38, 13);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "timer...";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(74, 430);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(139, 41);
            this.txtDescription.TabIndex = 20;
            // 
            // lblDkk2
            // 
            this.lblDkk2.AutoSize = true;
            this.lblDkk2.Location = new System.Drawing.Point(381, 410);
            this.lblDkk2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDkk2.Name = "lblDkk2";
            this.lblDkk2.Size = new System.Drawing.Size(29, 13);
            this.lblDkk2.TabIndex = 19;
            this.lblDkk2.Text = "DKK";
            // 
            // txtLatestBid
            // 
            this.txtLatestBid.Location = new System.Drawing.Point(311, 406);
            this.txtLatestBid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLatestBid.Name = "txtLatestBid";
            this.txtLatestBid.ReadOnly = true;
            this.txtLatestBid.Size = new System.Drawing.Size(65, 20);
            this.txtLatestBid.TabIndex = 18;
            // 
            // lblLatestBid
            // 
            this.lblLatestBid.AutoSize = true;
            this.lblLatestBid.Location = new System.Drawing.Point(247, 406);
            this.lblLatestBid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLatestBid.Name = "lblLatestBid";
            this.lblLatestBid.Size = new System.Drawing.Size(67, 13);
            this.lblLatestBid.TabIndex = 17;
            this.lblLatestBid.Text = "Højeste bud:";
            // 
            // lblDkk
            // 
            this.lblDkk.AutoSize = true;
            this.lblDkk.Location = new System.Drawing.Point(380, 383);
            this.lblDkk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDkk.Name = "lblDkk";
            this.lblDkk.Size = new System.Drawing.Size(29, 13);
            this.lblDkk.TabIndex = 16;
            this.lblDkk.Text = "DKK";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(311, 381);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(65, 20);
            this.textBox3.TabIndex = 15;
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Location = new System.Drawing.Point(247, 383);
            this.lblMinPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(63, 13);
            this.lblMinPrice.TabIndex = 14;
            this.lblMinPrice.Text = "Mindstepris:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 430);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Beskrivelse:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 403);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(10, 405);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(52, 13);
            this.lblArtist.TabIndex = 10;
            this.lblArtist.Text = "Kunstner:";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(74, 380);
            this.txtTitel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.ReadOnly = true;
            this.txtTitel.Size = new System.Drawing.Size(139, 20);
            this.txtTitel.TabIndex = 9;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(10, 381);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(30, 13);
            this.lblTitel.TabIndex = 8;
            this.lblTitel.Text = "Titel:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(74, 357);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(76, 20);
            this.txtNumber.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(10, 357);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(24, 13);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Nr.:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 284);
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
            this.buttonPanel.Location = new System.Drawing.Point(0, 480);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonPanel.Size = new System.Drawing.Size(409, 81);
            this.buttonPanel.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(351, 2);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(291, 2);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(56, 19);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(231, 2);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 19);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(171, 2);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 19);
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
            this.panel1.Location = new System.Drawing.Point(409, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 561);
            this.panel1.TabIndex = 1;
            // 
            // panelEditTimer
            // 
            this.panelEditTimer.Controls.Add(this.comboBoxTimer);
            this.panelEditTimer.Controls.Add(this.button1);
            this.panelEditTimer.Controls.Add(this.lblTimerEdit);
            this.panelEditTimer.Location = new System.Drawing.Point(5, 25);
            this.panelEditTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEditTimer.Name = "panelEditTimer";
            this.panelEditTimer.Size = new System.Drawing.Size(130, 74);
            this.panelEditTimer.TabIndex = 26;
            // 
            // comboBoxTimer
            // 
            this.comboBoxTimer.FormattingEnabled = true;
            this.comboBoxTimer.Location = new System.Drawing.Point(44, 14);
            this.comboBoxTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTimer.Name = "comboBoxTimer";
            this.comboBoxTimer.Size = new System.Drawing.Size(83, 21);
            this.comboBoxTimer.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 24;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTimerEdit
            // 
            this.lblTimerEdit.AutoSize = true;
            this.lblTimerEdit.Location = new System.Drawing.Point(3, 20);
            this.lblTimerEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerEdit.Name = "lblTimerEdit";
            this.lblTimerEdit.Size = new System.Drawing.Size(36, 13);
            this.lblTimerEdit.TabIndex = 22;
            this.lblTimerEdit.Text = "Timer:";
            // 
            // panelEditInterval
            // 
            this.panelEditInterval.Controls.Add(this.OKInterval);
            this.panelEditInterval.Controls.Add(this.label1);
            this.panelEditInterval.Controls.Add(this.textBox4);
            this.panelEditInterval.Location = new System.Drawing.Point(5, 114);
            this.panelEditInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEditInterval.Name = "panelEditInterval";
            this.panelEditInterval.Size = new System.Drawing.Size(130, 74);
            this.panelEditInterval.TabIndex = 25;
            // 
            // OKInterval
            // 
            this.OKInterval.Location = new System.Drawing.Point(73, 53);
            this.OKInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OKInterval.Name = "OKInterval";
            this.OKInterval.Size = new System.Drawing.Size(56, 19);
            this.OKInterval.TabIndex = 24;
            this.OKInterval.Text = "OK";
            this.OKInterval.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Interval:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 17);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 0;
            // 
            // lblAdminTools
            // 
            this.lblAdminTools.AutoSize = true;
            this.lblAdminTools.Location = new System.Drawing.Point(3, 3);
            this.lblAdminTools.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminTools.Name = "lblAdminTools";
            this.lblAdminTools.Size = new System.Drawing.Size(84, 13);
            this.lblAdminTools.TabIndex = 0;
            this.lblAdminTools.Text = "Admin værktøjer";
            // 
            // StartAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 561);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "StartAuction";
            this.Text = "Start Auktion";
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