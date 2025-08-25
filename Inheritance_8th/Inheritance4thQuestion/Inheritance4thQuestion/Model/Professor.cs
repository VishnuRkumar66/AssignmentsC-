namespace Inheritance4thQuestion.Models
{
    public class Professor : Person
    {
        public string EmpId { get; set; }

        public Professor(string name, string empId, string major)
            : base(name, major)
        {
            EmpId = empId;
        }

        public void Teach()
        {
            Console.WriteLine($"Professor {Name} ({Major}) is teaching.");
        }

        public override string ToString()
        {
            return $"Professor: {Name}, EmpID: {EmpId}, Major: {Major}";
        }
    }
}
