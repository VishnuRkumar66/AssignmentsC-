using System;

namespace TemperatureMonitor
{
    public class Temperatures
    {
        // Step 1: Declare delegate
        public delegate void TemperatureHandler(string message);

        // Step 2: Declare event
        public event TemperatureHandler OnCriticalTemperature;

        // field to hold temperature value
        private int _temperature;

        // Property to get/set temperature
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Console.WriteLine($"Temperature set to: {_temperature}°C");

                // Step 3: Check limits and raise events
                if (_temperature > 100)
                {
                    OnCriticalTemperature?.Invoke("Temperature is too high!");
                    Console.WriteLine("----------------------------------------------------");
                }
                else if (_temperature < 0)
                {
                    OnCriticalTemperature?.Invoke("Temperature below freezing point!");
                    Console.WriteLine("----------------------------------------------------");
                }
            }
        }
    }
}
