
namespace PolymorphismAug20.Model
{
    //base class
    public class GeometricFigure
    {
        //common fields/attributes/properties
        public int NoOfSides {  get; set; }

        //default constructor
        public GeometricFigure() { }
        //parameterized constructor

        //method to accept sides

        public virtual void Accept()
        {
            Console.WriteLine("enter the number of sides:");
            NoOfSides = int.Parse(Console.ReadLine());
        }
        //method to display sides
        public virtual void Display()
        {
            Console.WriteLine($"number of sides : {NoOfSides}");
        }
        //virtual method to calculate area

        public virtual double Area()
        {
            return 0;
        }

    }
}
