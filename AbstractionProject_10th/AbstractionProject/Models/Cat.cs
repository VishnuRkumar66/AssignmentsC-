using System;
using AbstractionProject.AbstractClasses;

namespace AbstractionProject.Models
{
    public class Cat : Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Cats Say Meoow");
        }
    }
}
