class PrimeNumberException : Exception
{
    // Custom exception for prime number detection
    public PrimeNumberException(string message)
        : base(message) { }
}

// Main program to generate random numbers and check for primes
class RandomPrimeCheck
{
    static int GetRandomNumber()
    {
        // Generate a random number between 1 and 50
        Random rand = new Random();
        int num = rand.Next(1, 51); // random 1–50
        // Check if the number is prime
        if (IsPrime(num))
        {
            throw new PrimeNumberException("Prime number generated: " + num);
        }
        // If not prime, return the number
        return num;
    }

    // Function to check if a number is prime
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        // If no divisors found, it's prime
        return true;
    }

    // Main method to execute the program
    static void Main()
    {
        try
        {
            int number = GetRandomNumber();
            Console.WriteLine("Random number generated: " + number);
        }
        // Catch and handle the custom prime number exception
        catch (PrimeNumberException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
    }
}
