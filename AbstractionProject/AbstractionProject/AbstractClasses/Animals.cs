using AbstractionAndInterfaces.Models;

namespace AbstractionAndInterfaces.AbstractClasses
{
    public abstract class Animals
    {
        // Properties
        public int NoOfLegs { get; set; }
        public string Color { get; set; }

        // Constructor
        protected Animals(int noOfLegs, string color)
        {
            NoOfLegs = noOfLegs;
            Color = color;
        }

        // Abstract methods (must be implemented in derived classes)
        public abstract void Cry();
        public abstract void Fly();
        public abstract void Walk();

        // Virtual method (optional override)
        public virtual void SaySomething()
        {
            Console.WriteLine("This animal says something...");
        }
    }
}
