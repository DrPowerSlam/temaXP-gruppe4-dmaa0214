using System;
using System.Windows.Forms;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{
    public partial class MemberAuction : Form
    {
        public MemberAuction()
        {
            InitializeComponent();
            foreach (Item artPiece in new ItemCtr().GetAllItems())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = artPiece.Author + ": " + artPiece.Title;
                lvItem.Tag = artPiece;
                listItem.Items.Add(lvItem);
            }
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