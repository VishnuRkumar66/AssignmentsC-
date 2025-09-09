using System;

namespace CollectionAssignment5.Models
{
    // Apartment class inheriting from Estate
    public class Apartment : Estate
    {
        public int Floor { get; set; }
        public bool HasElevator { get; set; }
        public bool IsFurnished { get; set; }

        // Constructor
        public Apartment(
            double area,
            double pricePerSqM,
            string location,
            int floor,
            bool hasElevator,
            bool isFurnished
        )
            : base(area, pricePerSqM, location)
        {
            Floor = floor;
            HasElevator = hasElevator;
            IsFurnished = isFurnished;
        }

        // Override method to display apartment details

        public override void DisplayDetails()
        {
            Console.WriteLine(
                $"Apartment in {Location} - {Area} m², "
                    + $"Price: {TotalPrice} "
                    + $"(Floor: {Floor}, Elevator: {HasElevator}, Furnished: {IsFurnished})"
            );
        }
    }
}
