using System;

namespace MethodAssignment18AUG.Utility
{
    public class IndividualDigit
    {
        public static void PrintDigits(int num)
        {
            if (num == 0)
                return;

            // Recursive call first (so we print left to right)
            PrintDigits(num / 10);

            Console.Write(num % 10 + " ");
        }
    }
}
