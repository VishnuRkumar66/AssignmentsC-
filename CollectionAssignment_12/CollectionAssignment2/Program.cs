using System.Collections;

namespace CollectionAssignment2
{
    // Create a phone index using SortedList
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedList with <string, string>
            SortedList phoneIndex = new SortedList();

            // Adding entries
            phoneIndex.Add("John", "9876543210");
            phoneIndex.Add("Alice", "9123456780");
            phoneIndex.Add("Michael", "9012345678");
            phoneIndex.Add("Sophia", "9988776655");

            Console.WriteLine("Phone Index (Sorted by Name):\n");

            // Display all entries
            foreach (DictionaryEntry entry in phoneIndex)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            // Searching for a contact
            Console.WriteLine("\nEnter a name to search:");
            string name = Console.ReadLine();

            if (phoneIndex.ContainsKey(name))
            {
                Console.WriteLine($"Phone number of {name}: {phoneIndex[name]}");
            }
            else
            {
                Console.WriteLine($"{name} not found in phone index.");
            }
        }
    }
}
