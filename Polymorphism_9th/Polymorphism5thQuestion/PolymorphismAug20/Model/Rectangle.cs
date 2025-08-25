
namespace PolymorphismAug20.Model
{
    public class Rectangle : GeometricFigure
    {
        //fields / attributes
        public double  Length { get; set; }
        public double Breadth { get; set; }

        //accept
        public override void Accept()
        {
            NoOfSides = 4;
            Console.WriteLine("Enter Length : ");
            Length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth : ");
            Breadth = Double.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            Console.WriteLine($"Rectangle  sides : {NoOfSides} , Length : {Length}  , Breadth : {Breadth}");
        }
        //Override method to calculate area

        public override double Area()
        {
            return Length * Breadth;
        }
    }
}
