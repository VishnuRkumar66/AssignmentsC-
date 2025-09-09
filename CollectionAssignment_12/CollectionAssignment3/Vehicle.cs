class Vehicle
{
    // Vehicle properties
    public string Model { get; set; }
    public string Owner { get; set; }
    public string Color { get; set; }

    // Constructor
    public Vehicle(string model, string owner, string color)
    {
        Model = model;
        Owner = owner;
        Color = color;
    }

    // Override ToString for easy display

    public override string ToString()
    {
        return $"Model: {Model}, Owner: {Owner}, Color: {Color}";
    }
}

// Class to manage vehicle registrations

class VehicleRegistration
{
    // Dictionary to hold license number as key and Vehicle as value
    private Dictionary<string, Vehicle> registry = new Dictionary<string, Vehicle>();

    // Add a new registration
    public void AddRegistration(string licenseNumber, Vehicle vehicle)
    {
        registry[licenseNumber] = vehicle; // overwrites if exists
    }

    // Retrieve vehicle by license number
    public Vehicle GetVehicle(string licenseNumber)
    {
        if (registry.ContainsKey(licenseNumber))
        {
            return registry[licenseNumber];
        }
        else
        {
            return null;
        }
    }
}
