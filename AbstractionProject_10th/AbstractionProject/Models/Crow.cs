using System;

namespace AbstractionProject.Models
{
    public class Crow : AnimalBase
    {
        public override string Cry() => "Caw Caw";

        public override void Fly() => Console.WriteLine("Crow flies up to 100 feet high");

        public override void Walk() => Console.WriteLine($"Crow walking with {NoOfLegs} legs");
    }
}
