using AbstractionAndInterfaces.Implementations;
using AbstractionAndInterfaces.Models;

namespace AbstractionAndInterfaces.Models
{
    public class Chicken : MyAnimals
    {
        public Chicken(int noOfLegs, string color)
            : base(noOfLegs, color) { }

        public override void Cry()
        {
            Console.WriteLine("Chicken says: Cluck Cluck");
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken can fly short distances, around 10 feet high.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Chicken is walking with {NoOfLegs} legs.");
        }
    }
}
