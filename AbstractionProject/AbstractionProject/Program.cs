using AbstractionAndInterfaces.AbstractClasses;
using AbstractionAndInterfaces.Implementations;
using AbstractionAndInterfaces.Models;

namespace AbstractionAndInterfaces
{
    class Program
    {
        static void Main()
        {
            // Mammals Example
            MyAnimals mammal = new MyAnimals { BodyTemp = 37 };
            Console.WriteLine($"Mammal Body Temp: {mammal.GetBodyTemp("Dog")}");

            // Abstract class example
            Animals cat = new Cat(4, "White");
            cat.SaySomething();

            Animals dog = new Dog(4, "Brown");
            dog.SaySomething();

            // Interface explicit implementation
            Numbers num = new Numbers();
            IFirst first = num;
            ISecond second = num;

            first.Display();
            Console.WriteLine(first.GetValue());
            second.Display();
            second.Demo();

            // Hierarchy example
            Animals crow = new Crow(2, "Black");
            crow.Cry();
            crow.Fly();
            crow.Walk();

            Animals goat = new Goat(4, "White");
            goat.Cry();
            goat.Fly();
            goat.Walk();

            Animals chicken = new Chicken(2, "Brown");
            chicken.Cry();
            chicken.Fly();
            chicken.Walk();
        }
    }
}
