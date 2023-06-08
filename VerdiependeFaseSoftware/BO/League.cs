using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdiependeFaseSoftware.BO
{
    public class League
    {
        
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Team> Teams { get; set; } = new List<Team> ();   

        public override bool Equals(object? obj)
        {
            if (obj is League otherLeague)
            {
                return Name.Equals(otherLeague.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
