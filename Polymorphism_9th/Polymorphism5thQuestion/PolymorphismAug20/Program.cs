using PolymorphismAug20.Model;

namespace PolymorphismAug20
{
    internal class Program
    {
        static void Main()
        {
            GeometricFigure figure = null;
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("Choose a shape: \n 1. Rectangle \n 2. Square \n 3. Circle \n 4. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        figure = new Rectangle();
                        break;
                    case 2:
                        figure = new Square();
                        break;
                    case 3:
                        figure = new Circle();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program!");
                        continue; // skip the code below
                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }
                // polymorphic behavior (only if valid figure is chosen)
                figure.Accept();
                figure.Display();
                Console.WriteLine($"Area = {figure.Area():F2}\n");
            }
        }
    }
}
