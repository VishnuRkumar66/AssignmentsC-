using System;

namespace AbstractionProject.Models
{
    public class Chicken : AnimalBase
    {
        public override string Cry() => "Cluck Cluck";

        public override void Fly() => Console.WriteLine("Chicken flies only short distance");

        public override void Walk() => Console.WriteLine($"Chicken walking with {NoOfLegs} legs");
    }
}
