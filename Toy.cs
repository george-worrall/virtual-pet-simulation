using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulation.Models
{
    public class Toy : Item
    {
        public int Boredom { get; set; }
        public int MoodBoost { get; set; }
        public int Uses { get; set; }

        public Toy(string name, int cost, int boredom, int moodBoost, int uses = 0)
        {
            Name = name;
            Cost = cost;
            Boredom = boredom;
            MoodBoost = moodBoost;
            Uses = uses;
        }
    }
}
