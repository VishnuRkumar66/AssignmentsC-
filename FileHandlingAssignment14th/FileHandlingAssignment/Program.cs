using System.Text;

// This program appends user input to a text file with exclusive write access.
class FileAppend
{
    static void Main()
    {
        string path = "data.txt";

        try
        {
            // Open file with exclusive write access (others can only read)

            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                Console.Write("Enter text to append: ");
                string text = Console.ReadLine();
                sw.WriteLine(text);
            }

            Console.WriteLine("Text appended successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
