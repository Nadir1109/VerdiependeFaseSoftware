using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIfaWithJSON.BO
{
    public class Team
    {
        public List<Player> Players { get; private set; }
        public string Name { get; private set; }

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }
    }
}
