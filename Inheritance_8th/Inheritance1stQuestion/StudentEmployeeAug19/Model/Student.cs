
namespace TaskAug19.Model
{
    public class Student : Person
    {
        // Fields
        public int Roll { get; set; }
        public double Marks { get; set; }

        // Constructor
        public Student(string name, int age, int roll, double marks) : base(name, age)
        {
            Roll = roll;
            Marks = marks;
        }

        public Student() { }

        // Method to input student data
        public void Get_data()
        {
            Read_data();


            Console.Write("Enter Roll No: ");
            Roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks: ");
            Marks = Convert.ToDouble(Console.ReadLine());
        }

        // Method to compute grade
        public string Compute_grade()
        {
            if (Marks >= 90)
                return "S";
            else if (Marks >= 80)
                return "A";
            else if (Marks >= 70)
                return "B";
            else if (Marks >= 60)
                return "C";
            else if (Marks >= 50)
                return "D";
            else if (Marks >= 40)
                return "E";
            else
                return "Fail";
        }

        // Show Student Data
        public void Show_Data()
        {
            Console.WriteLine("\n--- Student Details ---");
            Display_Data();
            Console.WriteLine($"Roll No: {Roll}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Grade: {Compute_grade()}");
        }
    }
}
