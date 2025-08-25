using System;
using ShapeTaskAug20.Model;

namespace ShapeTaskAug20
{
    internal class Program
    {
        static void Main()
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\nChoose a shape:");
                Console.WriteLine("1. Cube");
                Console.WriteLine("2. Cylinder");
                Console.WriteLine("3. Sphere");
                Console.WriteLine("4. Cone");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                Shape shape = null;

                switch (choice)
                {
                   
                    case 1: // Cube
                        Console.Write("Enter side length:");
                        double cubeInput = double.Parse(Console.ReadLine());
                        shape = new Cube("Cube", cubeInput);
                        break;


                    case 2: // Cylinder
                        Console.Write("Enter radius: ");
                        double cylRadius = double.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        double cylHeight = double.Parse(Console.ReadLine());
                        shape = new Cylinder("Cylinder", cylRadius, cylHeight);
                        break;

                    case 3: // Sphere
                        Console.Write("Enter radius: ");
                        double sphRadius = double.Parse(Console.ReadLine());
                        shape = new Sphere("Sphere", sphRadius);
                        break;

                    case 4: // Cone
                        Console.Write("Enter radius: ");
                        double coneRadius = double.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        double coneHeight = double.Parse(Console.ReadLine());
                        shape = new Cone("Cone", coneRadius, coneHeight);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        continue;

                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                // Polymorphism in action
                Console.WriteLine($"Volume of {shape.Name} = {shape.CalculateVolume():F2}");
            }
        }
    }
}
