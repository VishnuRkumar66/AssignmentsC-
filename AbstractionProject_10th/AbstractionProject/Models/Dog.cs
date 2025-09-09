using System;
using AbstractionProject.AbstractClasses;

namespace AbstractionProject.Models
{
    public class Dog : Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Dogs Say Bow Wow");
        }
    }
}
