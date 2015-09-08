using System;
using System.Windows.Forms;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{
    public partial class StartAuction : Form
    {
        private int timeLeft;
        
        private ItemCtr itemCtr = new ItemCtr();

        private AuctionCtr auctionCtr = new AuctionCtr();
        

        public StartAuction()
        {
            InitializeComponent();

            timer.Stop();
            timeLeft = 60;
            timer.Interval = 1000;
            timer.Tick += TimerTick;

            txtEditTimer.Text = timeLeft.ToString();

            //Disable/enable knapper
            btnHammerslag.Enabled = false;
            btnNext.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = false;
        }

        private void StartTimer()
        {
            timer.Start();
        }

        // TODO evt ændre til minutter
        private void EditTimer(int seconds)
        {
            timeLeft = seconds;
        }

        private void PauseTimer()
        {
            timer.Stop();
        }

        //TODO EndItem
        // This method runs when the timer reaches zero 
        // or the auctioneer ends the bidding
        private void EndItem(Item item)
        {
            // Save bid
            // Get next item
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0)
            {
                timer.Stop();
            }

            lblTimer.Text = timeLeft.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
            //Sørg for at den enable næste knap og pause knap.
            btnHammerslag.Enabled = true;
            btnPause.Enabled = true;

            MarkItem();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseTimer();
            MarkItem();
        }

        private void btnOKTimer_Click(object sender, EventArgs e)
        {
            EditTimer(Int32.Parse(txtEditTimer.Text));
        }

        private void btnHammerslag_Click(object sender, EventArgs e)
        {
            //TODO EndItem(item);
            btnNext.Enabled = true;
            MarkItem();
        }

        private void txtEditTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditTimer(Int32.Parse(txtEditTimer.Text));
            }
        }

        //TODO send en form for notification til MemberAuction om at auction er startet + selected Item
        private void btnStartAuction_Click(object sender, System.EventArgs e)
        {
            btnStart.Enabled = true;
            HandleStartAuction();
        }

        private void HandleStartAuction()
        {
            Auction currentAuction = auctionCtr.GetCurrentAuction();
            auctionCtr.MaxIndex = currentAuction.Items.Count-1;
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

            Item art = (Item)listItem.Items[auctionCtr.Index].Tag;
            ShowItem(art);
        }

        //TODO tilføj billedfiler
        private void ShowItem(Item item)
        {
            //picItem.ImageLocation...

            txtNumber.Text = item.Number.ToString();
            txtArtist.Text = item.Author;
            txtDescription.Text = item.Description;
            txtInterval.Text = itemCtr.CalculateInterval(item).ToString();
            txtMinPrice.Text = item.MinPrice.ToString();
            txtHighestBid.Text = item.MinPrice.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HandleNext();
            btnHammerslag.Enabled = false;
            btnPause.Enabled = false;
        }

        private void HandleNext()
        {
            if(auctionCtr.Index != auctionCtr.MaxIndex)
            {
                ResetSelection();
                auctionCtr.Index += 1;
                MarkItem();
                Item art = (Item)listItem.Items[auctionCtr.Index].Tag;
                ShowItem(art);
            }

            //stop or do nothing.
        }

        private void MarkItem()
        {
            
            listItem.Focus();
            listItem.Items[auctionCtr.Index].Selected = true;
        }

        private void ResetSelection()
        {
            listItem.Focus();
            listItem.Items[auctionCtr.Index].Selected = false;
        }


        
    }
}