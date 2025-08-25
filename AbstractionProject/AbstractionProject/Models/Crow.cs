using AbstractionAndInterfaces.AbstractClasses;
using AbstractionAndInterfaces.Implementations;
using AbstractionAndInterfaces.Models;

namespace AbstractionAndInterfaces.Models
{
    public class Crow : Animals
    {
        public Crow(int noOfLegs, string color)
            : base(noOfLegs, color) { }

        public override void Cry()
        {
            Console.WriteLine("Crow says: Caw Caw");
        }

        public override void Fly()
        {
            Console.WriteLine("Crow can fly up to 1000 feet.");
        }

        public override void SaySomething()
        {
            throw new NotImplementedException();
        }

        public override void Walk()
        {
            Console.WriteLine($"Crow hops and walks with {NoOfLegs} legs.");
        }
    }
}
