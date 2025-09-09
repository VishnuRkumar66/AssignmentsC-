using System;

namespace CollectionAssignment5.Models
{
    // House class inheriting from Estate
    internal class House : Estate
    {
        public double YardArea { get; set; }
        public int Floors { get; set; }
        public bool IsFurnished { get; set; }

        // Constructor
        public House(
            double area,
            double pricePerSqM,
            string location,
            double yardArea,
            int floors,
            bool isFurnished
        )
            : base(area, pricePerSqM, location)
        {
            YardArea = yardArea;
            Floors = floors;
            IsFurnished = isFurnished;
        }

        // Override method to display house details
        public override void DisplayDetails()
        {
            Console.WriteLine(
                $"House in {Location} - {Area} m² + Yard {YardArea} m², "
                    + $"Price: {TotalPrice}, Floors: {Floors}, Furnished: {IsFurnished}"
            );
        }
    }
}
