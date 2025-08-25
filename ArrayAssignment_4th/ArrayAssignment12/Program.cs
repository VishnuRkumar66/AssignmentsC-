using System;

namespace ArrayAssignment12
{
    public class Program
    {
        static void Main()
        {
            //First();
            //Second();
            //Third();
            //Fourth();
            //Fifth();
            //Sixth();
            //Seven();
            //Eight();
            //Nineth();
            //Tenth();
            //Eleven();
        }

        // 1. Count duplicate elements
        private static void First()
        {
            int[] a = { 2, 3, 4, 2, 3, 4 };
            int duplicateCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        duplicateCount++;
                }
            }

            Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
            Console.ReadKey();
        }

        // 2. Find max and min
        private static void Second()
        {
            int[] a = { 10, 25, 3, 45, 1, 99, 7 };
            int max = a[0],
                min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
            }

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
            Console.ReadKey();
        }

        // 3. Separate odd and even
        private static void Third()
        {
            int[] a = { 10, 25, 3, 44, 7, 12 };
            int[] even = new int[a.Length];
            int[] odd = new int[a.Length];
            int e = 0,
                o = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    even[e++] = a[i];
                else
                    odd[o++] = a[i];
            }

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < e; i++)
                Console.Write(even[i] + " ");
            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < o; i++)
                Console.Write(odd[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        // 4. Sort in descending order (no Array.Sort)
        private static void Fourth()
        {
            int[] a = { 10, 25, 3, 44, 7 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in Descending Order:");
            foreach (int num in a)
                Console.Write(num + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        // 5. Insert new value in sorted list
        private static void Fifth()
        {
            // array with one extra slot at the end
            int[] a = new int[6] { 10, 20, 30, 40, 50, 0 };
            int n = 5; // number of valid elements
            int newVal = 35;

            // find position to insert
            int pos = n - 1;
            while (pos >= 0 && a[pos] > newVal)
            {
                a[pos + 1] = a[pos]; // shift right
                pos--;
            }
            a[pos + 1] = newVal; // insert
            n++; // increase valid size

            Console.WriteLine("Array after inserting new value:");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.ReadKey();
        }

        // 6. Delete element at position
        private static void Sixth()
        {
            int[] a = { 10, 20, 30, 40, 50 };
            int pos = 3; // delete 3rd element (index 2)
            int n = a.Length;

            Console.WriteLine("Before deletion:");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine("\nAfter deletion:");
            for (int i = 0; i < n; i++)
            {
                if (i == pos - 1)
                    continue; // skip element at given position
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        // 7. Find second smallest element
        private static void Seven()
        {
            int[] a = { 10, 25, 3, 44, 7, 1 };

            int first,
                second;

            // initialize with first two
            if (a[0] < a[1])
            {
                first = a[0];
                second = a[1];
            }
            else
            {
                first = a[1];
                second = a[0];
            }

            // check remaining elements
            for (int i = 2; i < a.Length; i++)
            {
                if (a[i] < first)
                {
                    second = first;
                    first = a[i];
                }
                else if (a[i] < second && a[i] != first)
                {
                    second = a[i];
                }
            }

            Console.WriteLine("First smallest: " + first);
            Console.WriteLine("Second smallest: " + second);
            Console.ReadKey();
        }

        // 8. Addition of two matrices
        private static void Eight()
        {
            int[,] A =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            int[,] B =
            {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 },
            };

            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            int[,] sum = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i, j] = A[i, j] + B[i, j];
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // 9. Multiplication of two square matrices
        private static void Nineth()
        {
            int[,] A =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            int[,] B =
            {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 },
            };

            int n = A.GetLength(0);
            int[,] product = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    product[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        product[i, j] += A[i, k] * B[k, j];
                    }
                    Console.Write(product[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // 10. Check if two matrices are equal
        private static void Tenth()
        {
            int[,] A =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };

            int[,] B =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };

            bool isEqual = true;

            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        if (A[i, j] != B[i, j])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                }
            }

            if (isEqual)
                Console.WriteLine("Both matrices are equal.");
            else
                Console.WriteLine("Matrices are NOT equal.");

            Console.ReadKey();
        }

        // 11. Bubble sort
        private static void Eleven()
        {
            int[] a = { 10, 25, 3, 44, 7 };

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array after Bubble Sort:");
            foreach (int num in a)
                Console.Write(num + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
