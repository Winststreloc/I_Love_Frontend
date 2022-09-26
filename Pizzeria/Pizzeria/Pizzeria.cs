using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {
        public List<Employee> Employees { get; } = new List<Employee>();
        public List<Client> Users { get; } = new List<Client>();
        
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
            (string, string, Adress) userparam = HelloUser();
            Users.Add(Users[0]);
            while (!endApp)
            {
                Console.WriteLine("okey, you want create order?");
                string answer = Console.ReadLine();
                if (answer == "no")
                {
                    endApp = true;
                }
            }
            Console.WriteLine("Bye!");
            bool EnterValue()
            {
                return endApp;
            }
            EnterValue();
        }
        public (string, string, Adress) HelloUser()
        {
            Console.WriteLine("Hello, what's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Adress");
            Adress userAdress = new Adress(Console.ReadLine());
            Console.WriteLine("Well, enter you password");
            string userPassword = Console.ReadLine();
            return (userName, userPassword, userAdress);
        }

    }
   
}