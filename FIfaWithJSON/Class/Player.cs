using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIfaWithJSON.BO
{
    public class Player
    {
        public string Name { get; private set; }
        public int Attack { get; private set; }
        public int Control { get; private set; }
        public int Defend { get; private set; }
        public string Position { get;  set; }
        public string Nationality { get; private set; }
        public int Rating { get; private set; }

        public Player(string name, int attack, int control, int defend, string position, string nationality,int rating)
        {
            this.Name = name;
            this.Attack = attack;
            this.Control = control;
            this.Defend = defend;
            this.Position = position;
            this.Nationality = nationality;
            this.Rating = rating;
        }

        public Player(string position)
        {
            this.Position = position;
        }
        public Player(string position, int rating) 
        {
        this.Position = position;
        this.Rating   = rating;
        } 
        public override string ToString() 
        {
            return Name + Attack + Control + Defend + Position + Rating;
        }
    }
   
}
