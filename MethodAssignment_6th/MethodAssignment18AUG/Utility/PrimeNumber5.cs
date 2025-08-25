
namespace MethodAssignment18AUG.Utility
{
    public class PrimeNumber5
    {
        public static bool  PrimeNumber(int n)
            {
        if (n <= 1) return false; // numbers <=1 are not prime

        for (int i = 2; i <= Math.Sqrt(n); i++) // check divisibility up to sqrt(n)
        {
            if (n % i == 0)
                return false; // divisible by i → not prime
        }

        return true; // no divisors found → prime
    }
}
}
