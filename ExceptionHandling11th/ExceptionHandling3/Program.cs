class ExceptionHandling3
{
    // Demonstrates handling an IndexOutOfRangeException
    // when accessing an array element outside its bounds.
    static void Main()
    {
        int[] arr = new int[10];
        // Initialize array with values 1 to 10

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        // Attempt to access the 11th element (index 10)
        try
        {
            Console.WriteLine("11th element = " + arr[10]); // Index 10 → out of bounds
        }
        // Catch the specific IndexOutOfRangeException
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Tried to access element outside array bounds!");
        }
        // Wait for user input before closing
        Console.ReadKey();
    }
}
