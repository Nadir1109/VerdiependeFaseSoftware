﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdiependeFaseSoftware.BO
{
    public class Team
    {
        public List<Player> players = new List<Player>();
       
        public string Name { get; private set; }
        public int LeagueID { get; set; }

        public Team() { }
        public Team(string name)
        {
            players = new List<Player>();
        }
    }
}
