class ReadCharacters
{
    static void Main()
    {
        // Define the file path
        string path = "data.txt";
        // Ensure the file exists
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                sr.Read(); // Skip 1st char
                sr.Read(); // Skip 2nd char
                // Now read 5 characters starting from the 3rd character
                char[] temp = new char[5];

                sr.Read(temp, 0, 5);

                Console.WriteLine("Five characters starting from 3rd: " + new string(temp));
            }
        }
        // Handle any errors that may occur
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
