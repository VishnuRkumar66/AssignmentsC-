using TemperatureMonitor;

namespace DelegateAssignment1
{
    class Program
    {
        static void Main()
        {
            // Step 4: Create sensor instance
            Temperatures sensor = new Temperatures();

            // Step 5: Subscribe to event
            sensor.OnCriticalTemperature += ShowWarning;

            // Simulate rise and fall of temperature
            sensor.Temperature = 25; // normal
            sensor.Temperature = 80; // normal
            sensor.Temperature = 101; // event raised
            sensor.Temperature = -5; // event raised
            sensor.Temperature = 150; // event raised
        }

        // Event handler
        static void ShowWarning(string message)
        {
            Console.WriteLine(">>> ALERT: " + message);
        }
    }
}
