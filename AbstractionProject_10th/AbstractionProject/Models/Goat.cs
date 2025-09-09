using System;

namespace AbstractionProject.Models
{
    public abstract class AnimalBase
    {
        public int NoOfLegs { get; set; }
        public string Color { get; set; }

        public abstract string Cry();
        public abstract void Fly();
        public abstract void Walk();
    }

    public class Goat : AnimalBase
    {
        public override string Cry() => "Baa Baa";

        public override void Fly() => Console.WriteLine("Goats cannot fly");

        public override void Walk() => Console.WriteLine($"Goat walking with {NoOfLegs} legs");
    }
}
