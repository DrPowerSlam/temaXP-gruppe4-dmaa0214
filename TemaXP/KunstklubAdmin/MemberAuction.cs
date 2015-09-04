using System;
using System.Windows.Forms;

namespace KunstklubAdmin
{
    public partial class MemberAuction : Form
    {
        public MemberAuction()
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

        private void MemberAuction_Load(object sender, EventArgs e)
        {
        }
    }
}