namespace CollectionAssignment5.Models
{
    // Employee class representing an employee in the real estate agency
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; } // in years

        // Constructor
        public Employee(string name, string position, int experience)
        {
            Name = name;
            Position = position;
            Experience = experience;
        }

        // Override ToString method for easy display
        public override string ToString()
        {
            return $"{Name} ({Position}, {Experience} years experience)";
        }
    }
}
