using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIfaWithJSON.BO
{
    internal class League
    {
            public string Name { get; private set; }
            public string Country { get; private set; }
            public List<Team> Teams { get; private set; } = new List<Team>();
        }
}
