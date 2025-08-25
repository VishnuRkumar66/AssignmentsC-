namespace ShapeTaskAug20.Model
{
    public class Cylinder : Shape
    {
        // properties for dimensions
        public double Radius { get; set; }
        public double Height { get; set; }

        // default constructor
        public Cylinder() { }

        // parameterized constructor
        public Cylinder(string name, double radius, double height)
        {
            Name = name;
            Radius = radius;
            Height = height;
        }

        // override method to calculate volume
        public override double CalculateVolume()
        {
            // Volume of a cylinder = π * r^2 * h
            return System.Math.PI * Radius * Radius * Height;
        }
    }
}
