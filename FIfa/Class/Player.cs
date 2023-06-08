using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIfa.Class
{
    public class Player
    {

        public string Name { get; set; }
        public int Attack { get; set; }
        public int Control { get; set; }
        public int Defend { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public int Rating { get; set; }

       public Player(string name, int attack, int control, int defend, string position, string nationality, int rating)
        {
            if (string.IsNullOrEmpty(name) || (string.IsNullOrEmpty(nationality)))
            {
                throw new ArgumentException("Naam moet worden opgegeven.", nameof(name));
            }

            if (attack < 0 || attack > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(attack), "Aanval moet tussen 0 en 100 liggen.");
            }


            Name = name;
            Attack = attack;
            Control = control;
            Defend = defend;
            Position = position;
            Nationality = nationality;
            Rating = rating;

            
        }
    }

}
