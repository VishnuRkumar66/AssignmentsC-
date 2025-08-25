namespace ShapeTaskAug20.Model
{
    public class Cone : Shape
    {
        // Properties for dimensions
        public double Radius { get; set; }
        public double Height { get; set; }

        // Default constructor
        public Cone() { }

        // Parameterized constructor
        public Cone(string name, double radius, double height)
        {
            Name = name;
            Radius = radius;
            Height = height;
        }

        // Override method to calculate volume
        public override double CalculateVolume()
        {
            // Volume of a cone = (1/3) * π * r^2 * h
            return (1.0 / 3.0) * System.Math.PI * Radius * Radius * Height;
        }
    }
}
