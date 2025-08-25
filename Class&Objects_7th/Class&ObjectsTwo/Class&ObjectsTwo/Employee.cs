using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsTwo
{
    public class Employee
    {
        // Fields
        private string name;
        private double baseSalary;
        private int yearsOfService;

        // Constructor
        public Employee(string name, double baseSalary, int yearsOfService)
        {
            this.name = name;
            this.baseSalary = baseSalary;
            this.yearsOfService = yearsOfService;
        }

        // Method to calculate bonus
        public double CalculateBonus()
        {
            return baseSalary * 0.05 * yearsOfService;
        }

        // Method to calculate total salary
        public double TotalSalary()
        {
            return baseSalary + CalculateBonus();
        }

        // Override ToString to show details
        public override string ToString()
        {
            return $"Employee: {name}, Base Salary: {baseSalary:C}, "
                + $"Years of Service: {yearsOfService}, "
                + $"Bonus: {CalculateBonus():C}, "
                + $"Total Salary: {TotalSalary():C}";
        }
    }
}
