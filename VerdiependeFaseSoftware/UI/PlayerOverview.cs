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
using VerdiependeFaseSoftware.Classes;

namespace VerdiependeFaseSoftware.UI
{
    public partial class PlayerOverview : Form
    {
        private DatabaseConnection _conn;
        public PlayerOverview()
        {
            InitializeComponent();
        }

        private void PlayerOverview_Load(object sender, EventArgs e)
        {
            lvwPlayerOverview.Columns.Add("PlayerID", 100);
            lvwPlayerOverview.Columns.Add("Playername", 100);
            lvwPlayerOverview.Columns.Add("PAttack", 100);
            lvwPlayerOverview.Columns.Add("Pcontrol", 100);
            lvwPlayerOverview.Columns.Add("Pdefend", 100);
            lvwPlayerOverview.Columns.Add("Pposition", 100);
            lvwPlayerOverview.Columns.Add("Pnatonality", 100);
            lvwPlayerOverview.Columns.Add("Prating", 100);
            lvwPlayerOverview.Columns.Add("Team", 100);
            lvwPlayerOverview.View = View.Details;

            _conn = new DatabaseConnection();

            if (_conn.Connect())
            {
                List<Player> players = _conn.GetPlayers();

                foreach (Player player in players)
                {
                    ListViewItem item = new ListViewItem(player.playerID.ToString());
                    item.SubItems.Add(player.playerName);
                    item.SubItems.Add(player.attack.ToString());
                    item.SubItems.Add(player.control.ToString());
                    item.SubItems.Add(player.defend.ToString());
                    item.SubItems.Add(player.position);
                    item.SubItems.Add(player.nationality);
                    item.SubItems.Add(player.rating.ToString());
                    item.SubItems.Add(player.teamID.ToString());

                    lvwPlayerOverview.Items.Add(item);
                }

                _conn.Disconnect();
            }
            else
            {
                MessageBox.Show("Fout bij het verbinden met de database. Controleer uw databaseverbinding en probeer het opnieuw.");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _conn?.Disconnect();
        }
    }
}
