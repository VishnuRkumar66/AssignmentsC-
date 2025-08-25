using Polymorphism1stQuestion.Model;

namespace Rectangles.Model
{
    public class Rectangle : Shape
    {
        private double xCoordinate;
        private double yCoordinate;

        // Default constructor
        public Rectangle()
        {
            xCoordinate = 0;
            yCoordinate = 0;
        }

        // Parameterized constructor
        public Rectangle(double x, double y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }

        // Getters and Setters
        public double XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }

        public double YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        // Override method (dynamic polymorphism)
        public override double GetArea()
        {
            return xCoordinate * yCoordinate;
        }

        // Overloaded method (static polymorphism)
        public double GetArea(double width, double height)
        {
            return width * height;
        }
    }
}
