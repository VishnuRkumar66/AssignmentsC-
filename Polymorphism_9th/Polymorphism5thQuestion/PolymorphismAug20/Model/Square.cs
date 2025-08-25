
namespace PolymorphismAug20.Model
{
    public  class Square : GeometricFigure
    {
        public double Side {  get; set; }


        public override void Accept()
        {
            NoOfSides = 4;
            Console.WriteLine("enter side:");
            Side = int.Parse(Console.ReadLine());
        }
        //method to display sides
        public override void Display()
        {
            Console.WriteLine($"number of sides : {NoOfSides} , side :  {Side}");
        }
        //virtual method to calculate area

        public override double Area()
        {
            return Side * Side;
        }
    }
}
