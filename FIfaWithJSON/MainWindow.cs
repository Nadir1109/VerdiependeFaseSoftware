using FIfaWithJSON.BO;

namespace FIfaWithJSON
{
    public partial class frmFifa : Form
    {
        private List<Player> allPlayers;
        private List<Team> teams;
        private bool gameStarted = false;
        private Player selectedPlayer1;
        private Player selectedPlayer2;
        private bool player1Turn = true;
        private bool player1Selected;
        private bool player2Selected;

        public frmFifa()
        {
            InitializeComponent();
            allPlayers = new List<Player>();
            teams = new List<Team>();
        }

        private void frmFifa_Load(object sender, EventArgs e)
        {
            CreateAllPlayers();
            FillComboBoxWithTeams();
            lvwPlayer1.Columns.Add("PlayerName", 150);
            lvwPlayer2.Columns.Add("PlayerName", 150);
            lvwPlayer1.View = View.Details;
            lvwPlayer2.View = View.Details;
        }

        private void FillComboBoxWithTeams()
        {
            cmxClubPlayer1.Items.Clear();
            cmxClubPlayer2.Items.Clear();

            List<string> teamNames = new List<string>();
            foreach (Team team in teams)
            {
                teamNames.Add(team.Name);
            }

            cmxClubPlayer1.Items.AddRange(teamNames.ToArray());
            cmxClubPlayer2.Items.AddRange(teamNames.ToArray());
        }

        public void CreateAllPlayers()
        {
            Team teamNike = new Team("NIKE");
            teamNike.Players.Add(new Player("Lionel Messi", 94, 89, 92, "Forward", "Argentina", 92));
            teamNike.Players.Add(new Player("Cristiano Ronaldo", 93, 92, 91, "Forward", "Portugal", 92));
            teamNike.Players.Add(new Player("Robert Lewandowski", 92, 85, 91, "Forward", "Poland", 90));

            Team adidasTeam = new Team("Adidas");
            adidasTeam.Players.Add(new Player("Neymar Jr.", 91, 96, 88, "Forward", "Brazil", 90));
            adidasTeam.Players.Add(new Player("Kevin De Bruyne", 90, 78, 85, "Midfielder", "Belgium", 91));
            adidasTeam.Players.Add(new Player("Kylian Mbappé", 90, 97, 88, "Forward", "France", 94));

            teams.Add(teamNike);
            teams.Add(adidasTeam);
        }

        private void playerOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPlayers allPlayers = new AllPlayers();
            allPlayers.Show();
        }

        private void btnGetRandomPlayer1_Click(object sender, EventArgs e)
        {
            string selectedClub = cmxClubPlayer1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedClub))
            {
                List<Player> players = GetPlayersByClub(selectedClub);
                DisplayPlayersInListView(players, lvwPlayer1);
            }
        }

        private void btnGetRandomPlayer2_Click(object sender, EventArgs e)
        {
            string selectedClub = cmxClubPlayer2.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedClub))
            {
                List<Player> players = GetPlayersByClub(selectedClub);
                DisplayPlayersInListView(players, lvwPlayer2);
            }
        }

        private List<Player> GetPlayersByClub(string clubName)
        {
            List<Player> players = new List<Player>();
            Team selectedTeam = teams.FirstOrDefault(t => t.Name.Equals(clubName, StringComparison.OrdinalIgnoreCase));
            if (selectedTeam != null)
            {
                players = selectedTeam.Players;
            }

            return players;
        }

        private void DisplayPlayersInListView(List<Player> players, ListView listView)
        {
            listView.Items.Clear();

            foreach (Player player in players)
            {
                ListViewItem item = new ListViewItem(player.Name);
                item.SubItems.Add(player.Attack.ToString());
                item.SubItems.Add(player.Control.ToString());
                item.SubItems.Add(player.Defend.ToString());
                item.SubItems.Add(player.Position);
                item.SubItems.Add(player.Nationality);
                item.SubItems.Add(player.Rating.ToString());

                listView.Items.Add(item);
            }
        }

        private void lvwPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPlayer1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwPlayer1.SelectedItems[0];
                string playerName = selectedItem.SubItems[0].Text;
                string attack = selectedItem.SubItems[1].Text;
                string control = selectedItem.SubItems[2].Text;
                string defend = selectedItem.SubItems[3].Text;

                btnAttackPlayer1.Text = attack;
                btnControlPlayer1.Text = control;
                btnDefendPlayer1.Text = defend;
                player1Selected = true;
                DisablePlayer2Buttons();
            }
        }

        private void lvwPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPlayer2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwPlayer2.SelectedItems[0];
                string playerName = selectedItem.SubItems[0].Text;
                string attack = selectedItem.SubItems[1].Text;
                string control = selectedItem.SubItems[2].Text;
                string defend = selectedItem.SubItems[3].Text;

                btnAttackPlayer2.Text = attack;
                btnControlPlayer2.Text = control;
                btnDefendPlayer2.Text = defend;
                player2Selected = true;
                DisablePlayer1Buttons();
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (cmxClubPlayer1.SelectedItem == null || cmxClubPlayer2.SelectedItem == null)
            {
                MessageBox.Show("Je hebt geen teams geselecteerd");
            }
            else
            {
                gameStarted = true;
                cmxClubPlayer1.Enabled = false;
                cmxClubPlayer2.Enabled = false;

                if (player1Selected)
                {
                    EnablePlayer1Buttons();
                }
            }
        }

        private void EnablePlayer1Buttons()
        {
            btnAttackPlayer1.Enabled = true;
            btnDefendPlayer1.Enabled = true;
            btnControlPlayer1.Enabled = true;
        }

        private void DisablePlayer1Buttons()
        {
            btnAttackPlayer1.Enabled = false;
            btnDefendPlayer1.Enabled = false;
            btnControlPlayer1.Enabled = false;
        }

        private void EnablePlayer2Buttons()
        {
            btnAttackPlayer2.Enabled = true;
            btnDefendPlayer2.Enabled = true;
            btnControlPlayer2.Enabled = true;
        }

        private void DisablePlayer2Buttons()
        {
            btnAttackPlayer2.Enabled = false;
            btnDefendPlayer2.Enabled = false;
            btnControlPlayer2.Enabled = false;
        }
        private void btnAttackPlayer1_Click(object sender, EventArgs e)
        {
            if (gameStarted && player1Turn && !player1Selected)
            {
                // Code om de aanval van Player 1 uit te voeren

                player1Selected = true;
                btnAttackPlayer1.Enabled = false;
                btnDefendPlayer1.Enabled = false;
                btnControlPlayer1.Enabled = false;

                if (player2Selected)
                {
                    EnablePlayer2Buttons();
                }
            }
        }

        private void btnControlPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void btnDefendPlayer1_Click(object sender, EventArgs e)
        {

        }
    }
}
