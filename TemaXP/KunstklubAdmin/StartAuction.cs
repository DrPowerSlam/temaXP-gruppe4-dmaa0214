﻿using System;
using System.Windows.Forms;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{
    public partial class StartAuction : Form
    {
        private int timeLeft;

        private ItemCtr itemCtr = new ItemCtr();

        public StartAuction()
        {
            InitializeComponent();
            timer.Stop();
            timeLeft = 60;
            timer.Interval = 1000;
            timer.Tick += TimerTick;

            txtEditTimer.Text = timeLeft.ToString();
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
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseTimer();
        }

        private void btnOKTimer_Click(object sender, EventArgs e)
        {
            EditTimer(Int32.Parse(txtEditTimer.Text));
        }

        private void btnHammerslag_Click(object sender, EventArgs e)
        {
            //TODO EndItem(item);
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
            foreach (Item artPiece in itemCtr.GetAllItems()){
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = artPiece.Author + ": " + artPiece.Title;
                lvItem.Tag = artPiece;
                listItem.Items.Add(lvItem);
            }

            listItem.Focus();
            listItem.Items[0].Selected = true;

            Item art = (Item)listItem.Items[0].Tag;
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

    }
}