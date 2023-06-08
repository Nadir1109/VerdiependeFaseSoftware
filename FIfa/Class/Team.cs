using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIfa.Class
{
    public class Team
    {
        public List<Player> players = new List<Player>();

        public string Name { get; set; }
        public int LeagueID { get; set; }


        public Team()
        {

        }
    }
}
