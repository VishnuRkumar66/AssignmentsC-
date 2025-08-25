namespace Inheritance4thQuestion.Models
{
    public class Student : Person
    {
        public string StudentId { get; set; }

        public Student(string name, string studentId, string major)
            : base(name, major) // call base class constructor
        {
            StudentId = studentId;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} ({Major} Student) is studying.");
        }

        public override string ToString()
        {
            return $"Student: {Name}, ID: {StudentId}, Major: {Major}";
        }
    }
}
