using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerdiependeFaseSoftware.UI
{
    public partial class PlayerOverview : Form
    {
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


        }
    }
}
