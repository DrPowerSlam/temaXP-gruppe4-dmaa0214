using System;
using System.Windows.Forms;

namespace KunstklubAdmin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

        private void gåTilAuktionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberAuction memberAuction = new MemberAuction();
            memberAuction.Show();
        }
    }
}