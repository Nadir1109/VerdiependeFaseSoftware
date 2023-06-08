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



        private void btnGetRandomPlayer1_Click(object sender, EventArgs e)
        {
            if (cmxClubPlayer1.SelectedIndex >= 0)
            {
                string selectedClub = cmxClubPlayer1.SelectedItem.ToString();

                List<Player> players = conn.GetPlayersByClub(selectedClub);

                if (players.Count > 0)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(0, players.Count);

                    Player randomPlayer = players[randomIndex];

                    // Spelergegevens weergeven
                    lblPlayerName1.Text = randomPlayer.Name;
                    lblAttack.Text = randomPlayer.Attack.ToString();
                    lblControl.Text = randomPlayer.Control.ToString();
                    lblDefend.Text = randomPlayer.Defend.ToString();

                    // Clear de ListBox en voeg de speler toe
                    lbxPlayer1.Items.Clear();
                    lbxPlayer1.Items.Add(randomPlayer.Name);
                }
                else
                {
                    MessageBox.Show("Er zijn geen spelers beschikbaar voor deze club.");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een club.");
            }
        }
    }
}
