using AbstractionProject.AbstractClasses;
using AbstractionProject.Interfaces;
using AbstractionProject.Models;

namespace AbstractionProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Part A & B -----");
            MyAnimals animal = new MyAnimals { BodyTemp = 38 };
            animal.GetBodyTemp("Dog");
            animal.SaySomething();

            Console.WriteLine("\n----- Part D -----");
            Animals cat = new Cat();
            Animals dog = new Dog();
            cat.SaySomething();
            dog.SaySomething();

            Console.WriteLine("\n----- Part E -----");
            Numbers num = new Numbers();
            Ifirst first = num;
            Isecond second = num;

            first.Display();
            Console.WriteLine("GetValue: " + first.GetValue());
            second.Display();
            second.Demo();

            Console.WriteLine("\n----- Part F -----");
            AnimalBase goat = new Goat { NoOfLegs = 4, Color = "White" };
            AnimalBase crow = new Crow { NoOfLegs = 2, Color = "Black" };
            AnimalBase chicken = new Chicken { NoOfLegs = 2, Color = "Brown" };

            Console.WriteLine($"Goat Cry: {goat.Cry()}");
            goat.Walk();
            goat.Fly();

            Console.WriteLine($"Crow Cry: {crow.Cry()}");
            crow.Walk();
            crow.Fly();

            Console.WriteLine($"Chicken Cry: {chicken.Cry()}");
            chicken.Walk();
            chicken.Fly();
        }
    }
}
