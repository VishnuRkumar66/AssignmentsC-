class CVGenerator
{
    static void Main()
    {
        //  Create directory if it doesn't exist
        string folderPath = "CVs";
        Directory.CreateDirectory(folderPath);
        //  Get number of employees
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Location: ");
            string location = Console.ReadLine();
            //  Create file name
            string fileName = $"{name}_{location}.txt";
            //  Full path
            string fullPath = Path.Combine(folderPath, fileName);
            //  Write to file
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.WriteLine("Curriculum Vitae");
                sw.WriteLine("----------------");
                sw.WriteLine($"Name: {name}");
                sw.WriteLine($"Location: {location}");
            }
            //  Notify user
            Console.WriteLine($"CV generated: {fileName}");
        }
    }
}
