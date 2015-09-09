using System;
using System.Windows.Forms;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{
    public partial class StartAuction : Form
    {
        private const int DEFAULTTIMER = 60;
        private int timeLeft;

        private ItemCtr itemCtr = new ItemCtr();
        private Item currentItem;

        private AuctionCtr auctionCtr;

        public event EventHandler<NextItemChangedArgs> NextItemChanged;


        public StartAuction(AuctionCtr auctionCtr)
        {
            InitializeComponent();
            this.auctionCtr = auctionCtr;

            timer.Stop();
            timeLeft = DEFAULTTIMER;
            timer.Interval = 1000;
            timer.Tick += TimerTick;

            txtEditTimer.Text = timeLeft.ToString();

            //Disable/enable knapper
            btnHammerslag.Enabled = false;
            btnNext.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = false;
            btnOKInterval.Enabled = false;
            btnOKTimer.Enabled = false;
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

        private void TimerTick(object sender, EventArgs e)
        {

            if (timeLeft <= 0)
            {
                timer.Stop();
                lblTimer.Text = "00";
                HandleHammerslag();
            }
            else
            {
                timeLeft--;
                lblTimer.Text = timeLeft.ToString();
            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
            //Sørg for at den enable næste knap og pause knap.
            btnHammerslag.Enabled = true;
            btnPause.Enabled = true;
            btnOKInterval.Enabled = true;
            btnOKTimer.Enabled = true;


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
            HandleHammerslag();
        }

        //TODO call as event from "server"
        private void RegisterBid(Bid bid)
        {
            txtHighestBid.Text = bid.Amount.ToString();
            txtBidName.Text = bid.Member.Name;
        }

        private void HandleHammerslag()
        {
            auctionCtr.RegisterSale();
            timeLeft = 0;
            MarkItem();

            btnNext.Enabled = true;
            btnPause.Enabled = false;
            btnStart.Enabled = false;
            btnHammerslag.Enabled = false;

        }

        //TODO send en form for notification til MemberAuction om at auction er startet + selected Item
        private void btnStartAuction_Click(object sender, System.EventArgs e)
        {
            HandleStartAuction();
        }

        private void HandleStartAuction()
        {
            Auction currentAuction = auctionCtr.GetCurrentAuction();

            if (currentAuction != null && currentAuction.Items.Count > 0)
            {
                auctionCtr.MaxIndex = currentAuction.Items.Count - 1;

                foreach (Item artPiece in currentAuction.Items)
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = artPiece.Author + ": " + artPiece.Title;
                    lvItem.Tag = artPiece;
                    listItem.Items.Add(lvItem);
                }
            }

            MarkItem();
            ShowItem(GetNextItem());

            btnStart.Enabled = true;
        }

        private Item GetNextItem()
        {
            return currentItem = (Item)listItem.Items[auctionCtr.Index].Tag;
        }

        //TODO tilføj billedfiler
        private void ShowItem(Item item)
        {
            //picItem.ImageLocation...

            txtNumber.Text = item.Number.ToString();
            txtArtist.Text = item.Author;
            txtDescription.Text = item.Description;
            txtTitel.Text = item.Title;
            txtInterval.Text = itemCtr.CalculateInterval(item).ToString();
            txtMinPrice.Text = item.MinPrice.ToString();
            //txtHighestBid.Text = item.MinPrice.ToString();

            if (this.NextItemChanged != null)
            {
                this.NextItemChanged(this, new NextItemChangedArgs(this.currentItem));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HandleNext();
            timeLeft = DEFAULTTIMER;
            btnHammerslag.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnNext.Enabled = false;


        }

        private void HandleNext()
        {
            if (auctionCtr.Index != auctionCtr.MaxIndex)
            {
                ResetSelection();
                auctionCtr.Index += 1;
                MarkItem();
                ShowItem(GetNextItem());
            }

            //stop or do nothing.
        }

        //TODO can this be done better?
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

        private void btnOKInterval_Click(object sender, EventArgs e)
        {
            currentItem.Interval = Convert.ToInt32(txtSetInterval.Text);
            txtInterval.Text = itemCtr.CalculateInterval(currentItem).ToString();
        }

        private void txtEditTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditTimer(Int32.Parse(txtEditTimer.Text));
            }
        }
    }
}