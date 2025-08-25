using System;

namespace Assignment13AUG
{
    class Program
    {
        static void Main(string[] args)
        {
            //First(); // A
            // Second(); // B
            //Third(); // C
            //Fourth(); // D
            //Fifth(); // E
            //Sixth(); // F
            //Seventh(); // G
            //Eightth(); // H
            //Nineth(); // I
            //Tenth(); // J
            //Eleven(); // K
            Twelve(); // L
        }

        // A. Square natural numbers and their sum
        private static void First()
        {
            Console.Write("Enter the Limit: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("---------------------------------");
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i * i);
                sum += (i * i);
            }
            Console.WriteLine("Total sum is : " + sum);
            Console.ReadKey();
        }

        // B. Diamond pattern
        private static void Second()
        {
            int limit = 5;
            for (int i = 1; i <= limit; i++)
            {
                Console.Write(new string(' ', limit - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
            for (int i = limit - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', limit - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
            Console.ReadKey();
        }

        // C. Armstrong number
        private static void Third()
        {
            Console.Write("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n,
                result = 0;
            int digits = n.ToString().Length;

            while (n > 0)
            {
                int digit = n % 10;
                result += (int)Math.Pow(digit, digits);
                n /= 10;
            }

            if (result == temp)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not an Armstrong number");
            Console.ReadKey();
        }

        // D. Prime or not
        private static void Fourth()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = num > 1;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime number" : "Not prime");
            Console.ReadKey();
        }

        // E. Prime numbers in range
        private static void Fifth()
        {
            Console.Write("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end}:");
            for (int num = start; num <= end; num++)
            {
                bool isPrime = num > 1;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.Write(num + " ");
            }
            Console.ReadKey();
        }

        // F. Fibonacci series
        private static void Sixth()
        {
            Console.Write("Enter the limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int a = 0,
                b = 1;
            Console.Write($"{a} {b} ");
            for (int i = 2; i < limit; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadKey();
        }

        // G. Palindrome number
        private static void Seventh()
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num,
                rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine(temp == rev ? "Palindrome number" : "Not palindrome");
            Console.ReadKey();
        }

        // H. Numbers divisible by 9 between 100–200
        private static void Eightth()
        {
            int sum = 0;
            Console.WriteLine("Numbers divisible by 9 between 100 and 200:");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine("\nTotal Sum = " + sum);
            Console.ReadKey();
        }

        // I. Binary to decimal (without array, function, while)
        private static void Nineth()
        {
            Console.Write("Enter a binary number: ");
            int binary = Convert.ToInt32(Console.ReadLine());
            int decimalValue = 0,
                baseVal = 1;

            for (; binary > 0; binary /= 10)
            {
                int lastDigit = binary % 10;
                decimalValue += lastDigit * baseVal;
                baseVal *= 2;
            }
            Console.WriteLine("Decimal value = " + decimalValue);
            Console.ReadKey();
        }

        // J. Alphabet pattern
        private static void Tenth()
        {
            int limit = 4;
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write((char)(64 + j) + " ");
                for (int j = i - 1; j >= 1; j--)
                    Console.Write((char)(64 + j) + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // K. Strong numbers in range
        private static void Eleven()
        {
            Console.Write("Enter the limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                int temp = i,
                    sum = 0;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    int fact = 1;
                    for (int j = 1; j <= digit; j++)
                        fact *= j;
                    sum += fact;
                    temp /= 10;
                }
                if (sum == i)
                    Console.WriteLine($"{i} is a Strong number.");
            }
            Console.ReadKey();
        }

        // L. Print alphabet A pattern
        private static void Twelve()
        {
            Console.WriteLine("Pattern of 'A' with * :\n");

            int height = 7;

            for (int i = 0; i < height; i++)
            {
                if (i == 0) // top row
                    Console.WriteLine("  ***  ");
                else if (i == 3) // middle row
                    Console.WriteLine(" ***** ");
                else // other rows
                    Console.WriteLine(" *   * ");
            }

            Console.ReadKey();
        }
    }
}
