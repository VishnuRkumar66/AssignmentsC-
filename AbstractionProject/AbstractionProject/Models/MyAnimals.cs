using AbstractionAndInterfaces.AbstractClasses;
using AbstractionAndInterfaces.Models;

namespace AbstractionAndInterfaces.Implementations
{
    public class MyAnimals : Animals, IMammals
    {
        // Property with get/set
        public int BodyTemp { get; set; }

        // Constructor (default)
        public MyAnimals(int noOfLegs, string color)
            : base(4, "Brown") // default legs = 4, color = Brown
        {
            NoOfLegs = noOfLegs;
            Color = color;
        }

        // Implements IMammals method
        public int GetBodyTemp(string animalName)
        {
            Console.WriteLine($"{animalName} body temperature checked.");
            return BodyTemp;
        }

        // Implement abstract methods from Animals
        public override void Cry()
        {
            Console.WriteLine("Generic animal sound...");
        }

        public override void Fly()
        {
            Console.WriteLine("This mammal cannot fly.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Walking with {NoOfLegs} legs.");
        }
    }
}
