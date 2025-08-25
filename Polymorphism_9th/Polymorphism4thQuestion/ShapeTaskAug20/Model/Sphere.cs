namespace ShapeTaskAug20.Model
{
    public class Sphere : Shape
    {
        // property
        public double SphereRadius { get; set; }

        // default constructor
        public Sphere() { }

        // parameterized constructor
        public Sphere(string name, double radius)
        {
            Name = name;
            SphereRadius = radius;
        }

        // override method to calculate volume
        public override double CalculateVolume()
        {
            // Volume of a sphere = (4/3) * π * r^3
            return (4.0 / 3.0) * System.Math.PI * SphereRadius * SphereRadius * SphereRadius;
        }
    }
}
