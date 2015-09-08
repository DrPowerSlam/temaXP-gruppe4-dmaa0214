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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblMemberEmail = new System.Windows.Forms.Label();
            this.listItem = new System.Windows.Forms.ListView();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.btnBid = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTextLabel = new System.Windows.Forms.Label();
            this.lblTextUserPoints = new System.Windows.Forms.Label();
            this.lblTextPoints = new System.Windows.Forms.Label();
            this.lblTextMaxBid = new System.Windows.Forms.Label();
            this.txtMyPoints = new System.Windows.Forms.TextBox();
            this.txtMaxBid = new System.Windows.Forms.TextBox();
            this.lblTextDKK = new System.Windows.Forms.Label();
            this.listBid = new System.Windows.Forms.ListView();
            this.lblTextBids = new System.Windows.Forms.Label();
            this.txtBidPlusIntervalPrice = new System.Windows.Forms.TextBox();
            this.txtBidPrice = new System.Windows.Forms.TextBox();
            this.txtBidMember = new System.Windows.Forms.TextBox();
            this.lblDKK = new System.Windows.Forms.Label();
            this.lblLatestBid = new System.Windows.Forms.Label();
            this.lblBidByMember = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(12, 24);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(70, 13);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "MedlemNavn";
            // 
            // lblMemberEmail
            // 
            this.lblMemberEmail.AutoSize = true;
            this.lblMemberEmail.Location = new System.Drawing.Point(88, 24);
            this.lblMemberEmail.Name = "lblMemberEmail";
            this.lblMemberEmail.Size = new System.Drawing.Size(32, 13);
            this.lblMemberEmail.TabIndex = 2;
            this.lblMemberEmail.Text = "Email";
            // 
            // listItem
            // 
            this.listItem.Location = new System.Drawing.Point(15, 62);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(96, 487);
            this.listItem.TabIndex = 3;
            this.listItem.UseCompatibleStateImageBehavior = false;
            this.listItem.View = System.Windows.Forms.View.List;
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(146, 62);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(260, 193);
            this.picItem.TabIndex = 4;
            this.picItem.TabStop = false;
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Location = new System.Drawing.Point(143, 258);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(131, 13);
            this.lblItemInfo.TabIndex = 5;
            this.lblItemInfo.Text = "Information om Kunstværk";
            // 
            // btnBid
            // 
            this.btnBid.Location = new System.Drawing.Point(284, 449);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(75, 23);
            this.btnBid.TabIndex = 9;
            this.btnBid.Text = "Byd";
            this.btnBid.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(570, 75);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Timer";
            // 
            // lblTextLabel
            // 
            this.lblTextLabel.AutoSize = true;
            this.lblTextLabel.Location = new System.Drawing.Point(570, 62);
            this.lblTextLabel.Name = "lblTextLabel";
            this.lblTextLabel.Size = new System.Drawing.Size(54, 13);
            this.lblTextLabel.TabIndex = 11;
            this.lblTextLabel.Text = "TextLabel";
            // 
            // lblTextUserPoints
            // 
            this.lblTextUserPoints.AutoSize = true;
            this.lblTextUserPoints.Location = new System.Drawing.Point(570, 153);
            this.lblTextUserPoints.Name = "lblTextUserPoints";
            this.lblTextUserPoints.Size = new System.Drawing.Size(61, 13);
            this.lblTextUserPoints.TabIndex = 12;
            this.lblTextUserPoints.Text = "Mine points";
            // 
            // lblTextPoints
            // 
            this.lblTextPoints.AutoSize = true;
            this.lblTextPoints.Location = new System.Drawing.Point(636, 172);
            this.lblTextPoints.Name = "lblTextPoints";
            this.lblTextPoints.Size = new System.Drawing.Size(36, 13);
            this.lblTextPoints.TabIndex = 14;
            this.lblTextPoints.Text = "Points";
            // 
            // lblTextMaxBid
            // 
            this.lblTextMaxBid.AutoSize = true;
            this.lblTextMaxBid.Location = new System.Drawing.Point(570, 219);
            this.lblTextMaxBid.Name = "lblTextMaxBid";
            this.lblTextMaxBid.Size = new System.Drawing.Size(113, 13);
            this.lblTextMaxBid.TabIndex = 15;
            this.lblTextMaxBid.Text = "Du kan byde med max";
            // 
            // txtMyPoints
            // 
            this.txtMyPoints.Location = new System.Drawing.Point(573, 169);
            this.txtMyPoints.Name = "txtMyPoints";
            this.txtMyPoints.ReadOnly = true;
            this.txtMyPoints.Size = new System.Drawing.Size(51, 20);
            this.txtMyPoints.TabIndex = 16;
            // 
            // txtMaxBid
            // 
            this.txtMaxBid.Location = new System.Drawing.Point(573, 235);
            this.txtMaxBid.Name = "txtMaxBid";
            this.txtMaxBid.ReadOnly = true;
            this.txtMaxBid.Size = new System.Drawing.Size(51, 20);
            this.txtMaxBid.TabIndex = 17;
            // 
            // lblTextDKK
            // 
            this.lblTextDKK.AutoSize = true;
            this.lblTextDKK.Location = new System.Drawing.Point(636, 238);
            this.lblTextDKK.Name = "lblTextDKK";
            this.lblTextDKK.Size = new System.Drawing.Size(29, 13);
            this.lblTextDKK.TabIndex = 18;
            this.lblTextDKK.Text = "DKK";
            // 
            // listBid
            // 
            this.listBid.Location = new System.Drawing.Point(735, 62);
            this.listBid.Name = "listBid";
            this.listBid.Size = new System.Drawing.Size(115, 487);
            this.listBid.TabIndex = 19;
            this.listBid.UseCompatibleStateImageBehavior = false;
            // 
            // lblTextBids
            // 
            this.lblTextBids.AutoSize = true;
            this.lblTextBids.Location = new System.Drawing.Point(732, 46);
            this.lblTextBids.Name = "lblTextBids";
            this.lblTextBids.Size = new System.Drawing.Size(81, 13);
            this.lblTextBids.TabIndex = 20;
            this.lblTextBids.Text = "Liste af alle bud";
            // 
            // txtBidPlusIntervalPrice
            // 
            this.txtBidPlusIntervalPrice.Location = new System.Drawing.Point(146, 451);
            this.txtBidPlusIntervalPrice.Name = "txtBidPlusIntervalPrice";
            this.txtBidPlusIntervalPrice.ReadOnly = true;
            this.txtBidPlusIntervalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBidPlusIntervalPrice.TabIndex = 21;
            // 
            // txtBidPrice
            // 
            this.txtBidPrice.Location = new System.Drawing.Point(146, 378);
            this.txtBidPrice.Name = "txtBidPrice";
            this.txtBidPrice.ReadOnly = true;
            this.txtBidPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBidPrice.TabIndex = 22;
            // 
            // txtBidMember
            // 
            this.txtBidMember.Location = new System.Drawing.Point(259, 378);
            this.txtBidMember.Name = "txtBidMember";
            this.txtBidMember.ReadOnly = true;
            this.txtBidMember.Size = new System.Drawing.Size(100, 20);
            this.txtBidMember.TabIndex = 23;
            // 
            // lblDKK
            // 
            this.lblDKK.AutoSize = true;
            this.lblDKK.Location = new System.Drawing.Point(249, 454);
            this.lblDKK.Name = "lblDKK";
            this.lblDKK.Size = new System.Drawing.Size(29, 13);
            this.lblDKK.TabIndex = 24;
            this.lblDKK.Text = "DKK";
            // 
            // lblLatestBid
            // 
            this.lblLatestBid.AutoSize = true;
            this.lblLatestBid.Location = new System.Drawing.Point(149, 362);
            this.lblLatestBid.Name = "lblLatestBid";
            this.lblLatestBid.Size = new System.Drawing.Size(67, 13);
            this.lblLatestBid.TabIndex = 25;
            this.lblLatestBid.Text = "Højeste bud:";
            // 
            // lblBidByMember
            // 
            this.lblBidByMember.AutoSize = true;
            this.lblBidByMember.Location = new System.Drawing.Point(262, 362);
            this.lblBidByMember.Name = "lblBidByMember";
            this.lblBidByMember.Size = new System.Drawing.Size(36, 13);
            this.lblBidByMember.TabIndex = 26;
            this.lblBidByMember.Text = "Navn:";
            // 
            // MemberAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 561);
            this.Controls.Add(this.lblBidByMember);
            this.Controls.Add(this.lblLatestBid);
            this.Controls.Add(this.lblDKK);
            this.Controls.Add(this.txtBidMember);
            this.Controls.Add(this.txtBidPrice);
            this.Controls.Add(this.txtBidPlusIntervalPrice);
            this.Controls.Add(this.lblTextBids);
            this.Controls.Add(this.listBid);
            this.Controls.Add(this.lblTextDKK);
            this.Controls.Add(this.txtMaxBid);
            this.Controls.Add(this.txtMyPoints);
            this.Controls.Add(this.lblTextMaxBid);
            this.Controls.Add(this.lblTextPoints);
            this.Controls.Add(this.lblTextUserPoints);
            this.Controls.Add(this.lblTextLabel);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.lblItemInfo);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.lblMemberEmail);
            this.Controls.Add(this.lblMemberName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MemberAuction";
            this.Text = "UCN Kunst klub";
            this.Load += new System.EventHandler(this.MemberAuction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberEmail;
        private System.Windows.Forms.ListView listItem;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTextLabel;
        private System.Windows.Forms.Label lblTextUserPoints;
        private System.Windows.Forms.Label lblTextPoints;
        private System.Windows.Forms.Label lblTextMaxBid;
        private System.Windows.Forms.TextBox txtMyPoints;
        private System.Windows.Forms.TextBox txtMaxBid;
        private System.Windows.Forms.Label lblTextDKK;
        private System.Windows.Forms.ListView listBid;
        private System.Windows.Forms.Label lblTextBids;
        private System.Windows.Forms.TextBox txtBidPlusIntervalPrice;
        private System.Windows.Forms.TextBox txtBidPrice;
        private System.Windows.Forms.TextBox txtBidMember;
        private System.Windows.Forms.Label lblDKK;
        private System.Windows.Forms.Label lblLatestBid;
        private System.Windows.Forms.Label lblBidByMember;
    }
}

