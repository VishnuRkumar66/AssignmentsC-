class FileCopy
{
    static void Main()
    {
        try
        {
            // Prompt user for source and destination file paths
            Console.Write("Enter source file path: ");
            string source = Console.ReadLine();
            // Validate source file existence
            Console.Write("Enter destination file path: ");
            string dest = Console.ReadLine();
            // Copy file from source to destination
            File.Copy(source, dest, true);
            Console.WriteLine("File copied successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
