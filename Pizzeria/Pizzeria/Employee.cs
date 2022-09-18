using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkExperience { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"The employee's name is {Name}, he is {Age} years old, work experience is {WorkExperience}");
        }

    }
}
