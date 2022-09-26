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
            while (ExamUserFirstVisit())
            {
                Console.WriteLine("Enter you name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter you password");
                string password = Console.ReadLine();
                Client _userTemp = new Client(name, password);
                if (!ExamUser(_userTemp))
                {
                    Console.WriteLine("Incorrect parameters");
                }
            }
            (string, string, Adress) userparam = EnterUserParam();
            Client userTemp = new Client(userparam.Item1, userparam.Item3);
            Users.Add(userTemp);


            bool endApp = false;
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
        }
        public bool ExamUser(Client user)
        {
            return Users.Contains(user) ? true : false;
        }
        public bool ExamUserFirstVisit()
        {
            Console.WriteLine("Are you here for the first time?");
            return Console.ReadLine() == "no";
        }
        public (string, string, Adress) EnterUserParam()
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Adress");
            Adress userAdress = new Adress(Console.ReadLine());
            Console.WriteLine("Well, enter you password");
            string userPassword = Console.ReadLine();
            return (userName, userPassword, userAdress);
        }

    }
   
}