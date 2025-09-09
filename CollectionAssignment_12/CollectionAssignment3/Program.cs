namespace CollectionAssignment3
{
    internal class Program
    {
        static void Main()
        {
            VehicleRegistration registration = new VehicleRegistration();

            // Add vehicles
            registration.AddRegistration(
                "KL-01-AB-1234",
                new Vehicle("Honda City", "John", "Black")
            );
            registration.AddRegistration(
                "KL-02-XY-5678",
                new Vehicle("Suzuki Swift", "Alice", "Red")
            );
            registration.AddRegistration(
                "KL-03-PQ-2468",
                new Vehicle("Toyota Innova", "Michael", "White")
            );

            Console.WriteLine("Enter license number to search:");
            string license = Console.ReadLine();

            // Retrieve vehicle by license number
            Vehicle vehicle = registration.GetVehicle(license);

            // Display result
            if (vehicle != null)
            {
                Console.WriteLine($"Vehicle found: {vehicle}");
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
            }
        }
    }
}
