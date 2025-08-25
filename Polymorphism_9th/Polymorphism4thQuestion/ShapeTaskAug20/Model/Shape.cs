namespace ShapeTaskAug20.Model
{
    public  class Shape
    {
        // Common property
        public string Name { get; set; }

        // Default constructor
        public Shape() { }

        // Parameterized constructor
        public Shape(string name)
        {
            Name = name;
        }

        //default 
        public  virtual double CalculateVolume()
        {
            return 0;
        }
    }
}
