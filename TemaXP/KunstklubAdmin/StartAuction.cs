using System.Windows.Forms;
using TemaXP.CtrLayer;
using TemaXP.ModelLayer;

namespace KunstklubAdmin
{
    public partial class StartAuction : Form
    {
        public StartAuction()
        {
            InitializeComponent();
        }

        //TODO send en form for notification til MemberAuction om at auction er startet
        private void btnStartAuction_Click(object sender, System.EventArgs e)
        {
            foreach (Item artPiece in new ItemCtr().GetAllItems()){
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = artPiece.Author + ": " + artPiece.Title;
                lvItem.Tag = artPiece;
                listItem.Items.Add(lvItem);
            }
        }
    }
}