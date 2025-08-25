
namespace TaskAug19.Model
{
    public class Person
    {
        //fields
        public string Name { get; set; }
        public int Age { get; set; }

        // parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //default constructor
        public Person() { }


        //method to get data from the user
        public void Read_data()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        //method to display data 
        public void Display_Data()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
