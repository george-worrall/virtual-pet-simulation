using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulation.Models
{
    public class Pet
    {
        //general requirements
            public int Hunger { get; private set; } = 100;
            public int Boredom { get; private set; } = 0;
            public int Health { get; private set; } = 100;
            public int Mood { get; private set; } = 100;

        //appearance and details
            public string Name { get; private set; }
            public string Breed { get; private set; }
            public int Age { get; private set; }
            public string Colour { get; private set; }

        public Pet(string name, string breed, int age, string colour)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Colour = colour;

            Hunger = 100;
            Boredom = 0;
            Health = 100;
            Mood = 100;
        }

        public void Update()
        {

            Hunger -= 1;
            if (Hunger < 0) Hunger = 0;

        
            Boredom += 1;
            if (Boredom >= 100) Boredom = 100;

         
            Mood -= 1;
            if (Mood <= 0) Mood = 0;

            if (Hunger < 50 || Mood <20)
            {
                Health -= 1;
            }


            if (Health < 0) Health = 0;


        }


        public void PrintStats()
            {
                Console.WriteLine("Hunger:  " + Hunger);
                Console.WriteLine("Boredom: " + Boredom);
                Console.WriteLine("Health:  " + Health);
                Console.WriteLine("Mood:  " + Mood);
            }

        public void Feed(Food food)
        {
            // Prevent divide by zero if mood is 0
            double moodSafe = Math.Max(1, Mood);

            // In your system:
            // Hunger 100 = full, Hunger 0 = starving
            // So (100 - Hunger) tells us how hungry the pet actually is
            double actualHunger = 100 - Hunger;

            // Assignment formula (adapted for your hunger scale)
            double amountEaten = (100.0 / moodSafe) * actualHunger;

            // Increase hunger by food nutrition + required eaten amount
            Hunger += (int)(food.Nutrition + amountEaten);

            if (Hunger > 100) Hunger = 100;

            // Mood boost from food
            Mood += food.MoodBoost;
            if (Mood > 100) Mood = 100;

            // Small health boost
            Health += 5;
            if (Health > 100) Health = 100;
        }

        public void Play(Toy toy)
        {
            if (toy.Uses <= 0)
            {
                Console.WriteLine($"{toy.Name} is broken!");
                return;
            }

            // reduce boredom
            Boredom -= toy.Boredom;
            if (Boredom < 0) Boredom = 0;

            // increase mood
            Mood += toy.MoodBoost;
            if (Mood > 100) Mood = 100;

            // reduce toy durability
            toy.Uses--;

            // small health boost
            Health += 2;
            if (Health > 100) Health = 100;
        }

        public void GiveMedicine(Medicine medicine)
        {
            Health += medicine.HealthBoost;
            if(Health > 100) Health = 100;

            Hunger += medicine.HungerIncrease;
            if (Hunger > 100) Hunger = 100;
        }

        public void ApplyTemperatureEffect(double temp)
        {
            // Too cold
            if (temp < 17)
            {
                Health -= 1;
                Mood -= 1;
            }

            // Too hot
            else if (temp > 28)
            {
                Health -= 1;
                Mood -= 1;
            }

            // Clamp values
            if (Health < 0) Health = 0;
            if (Mood < 0) Mood = 0;
        }




    }
}
