using System;
using AbstractionProject.Interfaces;

namespace AbstractionProject.Models
{
    public class Numbers : Ifirst, Isecond
    {
        void Ifirst.Display()
        {
            Console.WriteLine("Display from Ifirst");
        }

        void Isecond.Display()
        {
            Console.WriteLine("Display from Isecond");
        }

        public int GetValue()
        {
            return 42;
        }

        public void Demo()
        {
            Console.WriteLine("Demo from Isecond");
        }
    }
}
