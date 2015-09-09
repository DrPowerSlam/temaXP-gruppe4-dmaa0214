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
        private AuctionCtr auctionCtr;
        private Item currentItem;

        //only for test and simulation purposes!!!
        private int idOfDummyMember = 1;

        

        public MemberAuction(AuctionCtr auctionCtr)
        {
            InitializeComponent();
            this.auctionCtr = auctionCtr;
            memberCtr = new MemberCtr();
            currentMember = memberCtr.FindMember(idOfDummyMember);
        }

        public void ItemChanged(object sender, NextItemChangedArgs e)
        {
            ShowItem(e.Item);
        }

        private void ShowItem(Item item)
        {
            this.currentItem = item;
            txtNumber.Text = currentItem.Number.ToString();
            txtArtist.Text = currentItem.Author;
            txtTitel.Text = currentItem.Title;
            txtDescription.Text = currentItem.Description;
            //txtHighestBid.Text = currentItem.MinPrice.ToString();
        }


        private void opretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAuction createauc = new CreateAuction();
            createauc.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAuction startAuction = new StartAuction(auctionCtr);
            startAuction.Show();
        }

        private void MemberAuction_Load(object sender, EventArgs e)
        {
            //load items
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

            //load member info
            lblMemberName.Text = currentMember.Name;
            lblMemberEmail.Text = currentMember.Email;
            txtMyPoints.Text = currentMember.Points.ToString();
            txtMaxBid.Text = memberCtr.CalculateMaxBid(currentMember).ToString();
        }
    }
}