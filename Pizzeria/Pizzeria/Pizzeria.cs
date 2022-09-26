using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {
        public List<Employee> Employees { get; set; }
        public string Name { get; }
        public string AdressPizzeria { get; }
        public Pizzeria(string name)
        {
            Name = name;
        }
        public Adress CreateAdress(string country, string city, string street, string home)
        {
            return new Adress(country, city, street, home);
        }

        public void AddEmployy(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }
        public void UserEnterParam()
        {
            bool endApp = false;
            (string, Adress) userparam = HelloUser();
            while (!endApp)
            {
                
            }
        }
        public (string, Adress) HelloUser()
        {
            Console.WriteLine("Hello, what's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Adress");
            Adress userAdress = new Adress(Console.ReadLine());
            return (userName, userAdress);
        }

    }
   
}