
namespace PolymorphismAug20.Model
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }
        
        public override void Accept()
        {
            NoOfSides = 0;
            Console.WriteLine("Enter Radius : ");
            Radius = Double.Parse(Console.ReadLine());
            }
        //method to display data
        public override void Display()
        {
            Console.WriteLine($"Circle  sides : {NoOfSides} , Radius : {Radius}  ");
        }
        //Override method to calculate area

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
