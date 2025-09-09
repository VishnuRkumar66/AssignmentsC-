using System;
using AbstractionProject.AbstractClasses;
using AbstractionProject.Interfaces;

namespace AbstractionProject.Models
{
    public class MyAnimals : Animals, IMammals
    {
        public int BodyTemp { get; set; }

        public int GetBodyTemp(string name)
        {
            Console.WriteLine($"{name} has body temperature {BodyTemp}°C");
            return BodyTemp;
        }

        public override void SaySomething()
        {
            Console.WriteLine("MyAnimals say something general");
        }
    }
}
