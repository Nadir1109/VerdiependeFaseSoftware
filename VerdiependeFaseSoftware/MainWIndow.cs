using VerdiependeFaseSoftware.UI;

namespace VerdiependeFaseSoftware
{
    public partial class MainWIndow : Form
    {
        public MainWIndow()
        {
            InitializeComponent();
        }

        private void playerOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerOverview player = new PlayerOverview();
            player.Show();
        }
    }
}