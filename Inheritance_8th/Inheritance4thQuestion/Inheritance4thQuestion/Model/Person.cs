namespace Inheritance4thQuestion.Models
{
    public class Person
    {
        // Common attributes
        public string Name { get; set; }
        public string Major { get; set; }

        // Constructor
        public Person(string name, string major)
        {
            Name = name;
            Major = major;
        }

        // Virtual method (can be overridden)
        public virtual void DisplayRole()
        {
            Console.WriteLine($"{Name} is associated with {Major}.");
        }
    }
}
