using FIfa.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FIfa.Pages
{
    public partial class CreatePlayer : Form
    {
        public CreatePlayer()
        {
            InitializeComponent();
        }

        private void btnSavePlayer_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int attack = int.Parse(numAttack.Text);
            int control = int.Parse(numControl.Text);
            int defend = int.Parse(numDefend.Text);
            string position = cmbxPosition.Text;
            string nationality = txbNationality.Text;
            int rating = int.Parse(txbRating.Text);

            Player player = new Player(name, attack, control, defend, position, nationality, rating);
        }
    }
}
