
namespace MethodAssignment18AUG.Utility
{
    public class Fibonacci4
    {
        public static void Fibonacci(int limit)
        {
            int a = 0;
            int b = 1;
            int temp = 0;

            Console.WriteLine("Fibonacci sequence up to " + limit + " terms:");

            while (a<limit)
            {
                {
                    Console.Write(a);  // print current number
                    temp = a;
                    a = b;
                    b += temp;
                }
                Console.WriteLine();

            }
        }
    }
}
