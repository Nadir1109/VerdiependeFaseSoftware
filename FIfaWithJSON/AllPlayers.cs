using FIfaWithJSON.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIfaWithJSON
{
    public partial class AllPlayers : Form
    {
        
        private List<Player> allPlayers; 
        private List<Team> teams;
      
        public AllPlayers()
        {
            InitializeComponent();
            allPlayers = new List<Player>();
            teams = new List<Team>();
            
        }

        private void AllPlayers_Load(object sender, EventArgs e)
        {
            lvwAllPlayersOverview.Columns.Add("Name", 75);
            lvwAllPlayersOverview.Columns.Add("Attack", 75);
            lvwAllPlayersOverview.Columns.Add("Control", 75);
            lvwAllPlayersOverview.Columns.Add("Defend", 75);
            lvwAllPlayersOverview.Columns.Add("Position", 75);
            lvwAllPlayersOverview.Columns.Add("Nationality", 150);
            lvwAllPlayersOverview.Columns.Add("Rating", 75);
            lvwAllPlayersOverview.Columns.Add("Team", 100);
            lvwAllPlayersOverview.View = View.Details;
            CreateAllPlayers(); 
            AddPlayersToListView();
            

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
        private void AddPlayersToListView()
        {
            
            foreach (Team team in teams)
            {
                foreach (Player player in team.Players)
                {
                    ListViewItem item = new ListViewItem(player.Name);
                    item.SubItems.Add(player.Attack.ToString());
                    item.SubItems.Add(player.Control.ToString());
                    item.SubItems.Add(player.Defend.ToString());
                    item.SubItems.Add(player.Position);
                    item.SubItems.Add(player.Nationality);
                    item.SubItems.Add(player.Rating.ToString());
                    item.SubItems.Add(team.Name); // Clubnaam toegevoegd
                    lvwAllPlayersOverview.Items.Add(item);
                }
            }
        }
    }
}