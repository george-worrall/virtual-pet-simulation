using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulation.Models
{
    public class Medicine : Item
    {
        public int HealthBoost { get; set; }
        public int HungerIncrease { get; set; }


        public Medicine(string name, int cost, int healthBoost, int hungerIncrease)
        {
            Name = name;
            Cost = cost;
            HealthBoost = healthBoost;
            HungerIncrease = hungerIncrease;
        }

    }
}
