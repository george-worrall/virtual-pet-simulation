using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetSimulation.Models;

namespace VirtualPetSimulation.System
{
    public class Inventory
    {
        public List<Item> Items { get; private set; } = new List<Item>();

        public void Add(Item item)
        {

            if (item is Food newFood)
            {
                var existing = Items.FirstOrDefault(i => i is Food f && f.Name == newFood.Name);
                if (existing != null)
                {
                    ((Food)existing).Quantity += newFood.Quantity;
                    return;
                }
            }

            Items.Add(item);
        }


        public void Remove(Item item)
        {
            Items.Remove(item);
        }

        public void Display()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            Console.WriteLine("\n--- Inventory ---");

            for (int i = 0; i < Items.Count; i++)
            {
                Item item = Items[i];

                if (item is Food food)
                {
                    Console.WriteLine($"{i + 1}. {food.Name} x{food.Quantity} (Nutrition: {food.Nutrition}, Mood: +{food.MoodBoost})");
                }
                else if (item is Toy toy)
                {
                    Console.WriteLine($"{i + 1}. {toy.Name} ({toy.Uses} uses left)");
                }
                else if (item is Medicine med)
                {
                    Console.WriteLine($"{i + 1}. {med.Name} (+{med.HealthBoost} Health)");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {item.Name}");
                }
            }
        }

    }
}
