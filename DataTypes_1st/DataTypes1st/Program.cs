class Program
{
    static void Main()
    {
        // First();   // A
        // Second();  // B
        // Third();   // C
        // Fourth();  // D
        // Fifth();   // E
    }

    // A. Login with 3 attempts
    private static void First()
    {
        string userId = "admin";
        string password = "1234";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter User ID: ");
            string inputUser = Console.ReadLine();

            Console.Write("Enter Password: ");
            string inputPass = Console.ReadLine();

            if (inputUser == userId && inputPass == password)
            {
                Console.WriteLine("Login Successful!");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Wrong credentials! Attempts left: {3 - attempts}");
            }
        }

        Console.WriteLine("User rejected after 3 wrong attempts.");
    }

    // B. Triangle
    private static void Second()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter the width of the triangle: ");
        int width = int.Parse(Console.ReadLine());

        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(num);
            Console.WriteLine();
        }
    }

    // C. Speed (km/h and mph)
    private static void Third()
    {
        Console.Write("Enter distance (in km): ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter time (in hours): ");
        double time = double.Parse(Console.ReadLine());

        double speedKmph = distance / time;
        double speedMph = speedKmph * 0.621371;

        Console.WriteLine($"Speed: {speedKmph:F2} km/h");
        Console.WriteLine($"Speed: {speedMph:F2} mph");
    }

    // D. Function x = y^2 + 2y + 1
    private static void Fourth()
    {
        Console.WriteLine("y\t x = y^2 + 2y + 1");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"{y}\t {x}");
        }
    }

    // E. (Same as C, speed calculation)
    private static void Fifth()
    {
        Console.Write("Enter distance (in km): ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter time (in hours): ");
        double time = double.Parse(Console.ReadLine());

        double speedKmph = distance / time;
        double speedMph = speedKmph * 0.621371;

        Console.WriteLine($"Speed: {speedKmph:F2} km/h");
        Console.WriteLine($"Speed: {speedMph:F2} mph");
    }
}
