namespace CollectionAssignment5.Models
{
    public abstract class Estate
    {
        // Common properties for all estate types
        public double Area { get; set; } // in square meters
        public double PricePerSqM { get; set; } // price per square meter
        public string Location { get; set; }

        public Estate(double area, double pricePerSqM, string location)
        {
            Area = area;
            PricePerSqM = pricePerSqM;
            Location = location;
        }

        // Calculate total price
        public double TotalPrice => Area * PricePerSqM;

        // Abstract method to display estate details
        public abstract void DisplayDetails();
    }
}
