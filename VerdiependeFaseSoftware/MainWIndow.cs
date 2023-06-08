using System.Drawing;
using VerdiependeFaseSoftware.BO;
using VerdiependeFaseSoftware.UI;

namespace VerdiependeFaseSoftware
{
    public partial class MainWIndow : Form
    {
        //Fifa fifa;
        private DatabaseConnection conn;
        public MainWIndow()
        {
            InitializeComponent();
            conn = new DatabaseConnection();

        }

        private void playerOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerOverview player = new PlayerOverview();
            player.Show();
        }

        private void MainWIndow_Load(object sender, EventArgs e)
        {
            //fifa = conn.GetAll();
            #region Combobox Vullen vanuit de database
            DatabaseConnection connectie = new DatabaseConnection();
            List<League> leagues = connectie.GetLeagues();
            foreach (League league in leagues)
            {
                cmxLeaguePlayer1.Items.Add(league.Name);
            }

            List<Team> teams = connectie.GetTeams();
            foreach (Team team in teams)
            {
                cmxClubPlayer1.Items.Add(team.Name);
            }
            #endregion

        }

        private void cmxLeaguePlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmxLeaguePlayer1.SelectedIndex >= 0)
            {
                string selectedLeague = cmxLeaguePlayer1.SelectedItem.ToString();

                List<Team> teams = conn.GetTeamsWithLeague(selectedLeague);

                cmxClubPlayer1.Items.Clear();

                foreach (Team team in teams)
                {
                    cmxClubPlayer1.Items.Add(team.Name);
                }
            }
            else
            {
                cmxClubPlayer1.Items.Clear();
            }
        }
    }
}
