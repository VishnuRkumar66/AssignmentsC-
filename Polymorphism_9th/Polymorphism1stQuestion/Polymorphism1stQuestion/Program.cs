using Rectangles.Model;

namespace Polymorphism1stQuestion
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Using parameterized constructor
            Rectangle rect1 = new Rectangle(10, 5);
            Console.WriteLine("Area (using fields): " + rect1.GetArea());

            // Using overloaded method
            Console.WriteLine("Area (using parameters): " + rect1.GetArea(7, 4));

            // Using setters
            Rectangle rect2 = new Rectangle();
            rect2.XCoordinate = 8;
            rect2.YCoordinate = 6;
            Console.WriteLine("Area (after setting values): " + rect2.GetArea());
        }
    }
}
