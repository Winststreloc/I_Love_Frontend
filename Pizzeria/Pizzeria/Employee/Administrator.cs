using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Administrator : Employee
    {
        private List<Employee> _employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void CreateSalary()
        {
            foreach (var employee in _employees)
            {
                if(employee.WorkExperience<=2)
                {
                    employee.Salary = employee.WorkExperience * 1000;
                }
                else if(employee.WorkExperience>2 && employee.WorkExperience<=5)
                {
                    employee.Salary = employee.WorkExperience * 2000;
                }
                else
                {
                    employee.Salary = employee.WorkExperience * 3000;
                }
                
            }
        }
        public void PrintSalary()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine($"salary of {employee.Name} is {employee.Salary}");
            }
        }
        public override void Perekyr() //chmolimorfizm
        {
            Console.WriteLine("Admin ne hodit na perekyr");
        }
    }
}
