using System;
using System.Windows.Forms;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{

    public partial class MemberAuction : Form
    {
        private Member currentMember;
        private MemberCtr memberCtr;
        private int idOfDummyMember = 21;

        private AuctionCtr auctionCtr = new AuctionCtr();

        public MemberAuction()
        {
            InitializeComponent();

            memberCtr = new MemberCtr();
            currentMember = memberCtr.FindMember(idOfDummyMember);
        }


        private void opretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAuction createauc = new CreateAuction();
            createauc.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAuction startAuction = new StartAuction();
            startAuction.Show();
        }

        private void MemberAuction_Load(object sender, EventArgs e)
        {
            Auction currentAuction = auctionCtr.GetCurrentAuction();
            auctionCtr.MaxIndex = currentAuction.Items.Count - 1;
            if (currentAuction != null && currentAuction.Items.Count > 0)
            {
                foreach (Item artPiece in currentAuction.Items)
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = artPiece.Author + ": " + artPiece.Title;
                    lvItem.Tag = artPiece;
                    listItem.Items.Add(lvItem);
                }
            }

            listItem.Focus();
            listItem.Items[auctionCtr.Index].Selected = true;

            txtMyPoints.Text = currentMember.Points.ToString();
            txtMaxBid.Text = memberCtr.CalculateMaxBid(currentMember).ToString();
        }
    }
}