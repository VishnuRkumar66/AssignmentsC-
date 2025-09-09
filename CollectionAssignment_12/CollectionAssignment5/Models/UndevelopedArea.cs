namespace CollectionAssignment5.Models
{
    // UndevelopedArea class inheriting from Estate
    public class UndevelopedArea : Estate
    {
        public UndevelopedArea(double area, double pricePerSqM, string location)
            : base(area, pricePerSqM, location) { }

        // Override method to display undeveloped area details
        public override void DisplayDetails()
        {
            Console.WriteLine($"Undeveloped Area in {Location} - {Area} m², Price: {TotalPrice}");
        }
    }
}
