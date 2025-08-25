using Inheritance4thQuestion.Models;

namespace Inheritance4thQuestion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create student
            Student s1 = new Student("Vishnu R Kumar", "S101", "Post Graduate");

            // Create professor
            Professor p1 = new Professor("Dr. Anjali", "EMP202", "Computer Science");

            // Create course
            Course c1 = new Course("Object Oriented Programming", 12);

            // Display details
            Console.WriteLine(s1);
            Console.WriteLine(p1);
            Console.WriteLine(c1);

            // Demonstrate behavior
            s1.Study();
            p1.Teach();
        }
    }
}
