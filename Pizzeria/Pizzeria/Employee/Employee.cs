using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Employee
    {
        public List<Employee> Employees { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkExperience { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"The employee's name is {Name}, he is {Age} years old," +
                $" work experience is {WorkExperience} and my salary is {Salary}");
        }
        public virtual void Perekyr()
        {
            Console.WriteLine("Vyshel na pereker");
        }
    }
}
