using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerdiependeFaseSoftware.BO;

namespace VerdiependeFaseSoftware.UI
{
    public partial class PlayerOverview : Form
    {
        private DatabaseConnection _conn;
        public PlayerOverview()
        {
            InitializeComponent();
            _conn = new DatabaseConnection();

        }

        private void PlayerOverview_Load(object sender, EventArgs e)
        {

            lvwPlayerOverview.Columns.Add("Playername", 200);
            lvwPlayerOverview.Columns.Add("Attack", 100);
            lvwPlayerOverview.Columns.Add("Control", 100);
            lvwPlayerOverview.Columns.Add("Defend", 100);
            lvwPlayerOverview.Columns.Add("Position", 100);
            lvwPlayerOverview.Columns.Add("Natonality", 100);
            lvwPlayerOverview.Columns.Add("Rating", 100);
            lvwPlayerOverview.Columns.Add("Team", 200);
            lvwPlayerOverview.View = View.Details;



            List<Team> teams = _conn.GetTeamsWithPlayers();

            foreach (Team team in teams)
            {
                foreach (Player player in team.players)
                {
                    ListViewItem item = new ListViewItem(player.Name);
                    item.SubItems.Add(player.Attack.ToString());
                    item.SubItems.Add(player.Control.ToString());
                    item.SubItems.Add(player.Defend.ToString());
                    item.SubItems.Add(player.Position);
                    item.SubItems.Add(player.Nationality);
                    item.SubItems.Add(player.Rating.ToString());
                    item.SubItems.Add(team.Name); // Voeg de teamnaam toe aan de lijst

                    lvwPlayerOverview.Items.Add(item);
                }
            }
        }
    }
}
