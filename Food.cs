using System.Xml.Linq;
using VirtualPetSimulation.Models;

public class Food : Item
{
    public int Nutrition { get; set; }
    public int MoodBoost { get; set; }
    public int Quantity { get; set; } = 1;  

    public Food(string name, int cost, int nutrition, int moodBoost = 0, int quantity = 1)
    {
        Name = name;
        Cost = cost;
        Nutrition = nutrition;
        MoodBoost = moodBoost;
        Quantity = quantity;
    }
}
