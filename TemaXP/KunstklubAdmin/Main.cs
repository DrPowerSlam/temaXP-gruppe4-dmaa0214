using System;
using System.Windows.Forms;
using TemaXP.CtrLayer;

namespace KunstklubAdmin
{
    public partial class Main : Form
    {
        private AuctionCtr auctionCtr;
        private MemberAuction memberAuction;
        private StartAuction startAuction;
        public Main()
        {
            InitializeComponent();
            auctionCtr = new AuctionCtr();
            memberAuction = new MemberAuction(auctionCtr);
            startAuction = new StartAuction(auctionCtr);
            startAuction.NextItemChanged += memberAuction.ItemChanged;
        }

        private void opretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAuction createauc = new CreateAuction();
            createauc.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startAuction.Show();
        }

        private void gåTilAuktionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberAuction.Show();
        }
    }
}