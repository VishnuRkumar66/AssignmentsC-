using AbstractionAndInterfaces.AbstractClasses;
using AbstractionAndInterfaces.Implementations;

namespace AbstractionAndInterfaces.Models
{
    public class Goat : Animals
    {
        public Goat(int noOfLegs, string color)
            : base(noOfLegs, color) { }

        public override void Cry()
        {
            Console.WriteLine("Goat says: Meeeeh");
        }

        public override void Fly()
        {
            Console.WriteLine("Goat cannot fly.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Goat is walking with {NoOfLegs} legs.");
        }
    }
}
