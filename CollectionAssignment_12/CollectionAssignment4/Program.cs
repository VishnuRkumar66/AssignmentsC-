using CollectionAssignment4.Models;

namespace CollectionAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManufacturingCompany Honda = new ManufacturingCompany(
                "Honda",
                "Japan",
                "Tokyo, Japan",
                "+149-123456",
                "+149-654321"
            );
            ManufacturingCompany Lambo = new ManufacturingCompany(
                "Lambo",
                "Italy",
                "Rome, ITALY",
                "+332-112233",
                "+332-445566"
            );

            // Create Car Models
            CarModel mercedes = new CarModel("Mercedes", "C320", 2008);
            CarModel bmw = new CarModel("BMW", "X5", 2012);
            CarModel audi = new CarModel("Audi", "A4", 2015);

            // Create Parts
            Part brakePads = new Part("P001", "Brake Pads", "Suspension", 50, 80, Honda);
            brakePads.AddCompatibleCar(mercedes);
            brakePads.AddCompatibleCar(bmw);

            Part tire = new Part("P002", "Sport Tire", "Tires and Wheels", 100, 150, Lambo);
            tire.AddCompatibleCar(bmw);
            tire.AddCompatibleCar(audi);

            // Display Part Details
            Console.WriteLine("Auto Parts Store Inventory:\n");
            brakePads.DisplayDetails();
            tire.DisplayDetails();
        }
    }
}
