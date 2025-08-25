namespace ShapeTaskAug20.Model
{
    public class Cube : Shape
    {
        // Property
        public double SideLength { get; set; }

        // Default constructor
        public Cube() { }

        // Parameterized constructor
        public Cube(string name, double sideLength)
        {
            Name = name;
            SideLength = sideLength;
        }

        // Override method to calculate volume
        public override double CalculateVolume()
        {
            // Volume of a cube = side^3
            return SideLength * SideLength * SideLength;
        }
    }
}
