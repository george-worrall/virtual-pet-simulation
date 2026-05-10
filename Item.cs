using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulation.Models
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
