using FIfa.Pages;

namespace FIfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePlayer player = new CreatePlayer();
            player.Show();
        }
    }
}