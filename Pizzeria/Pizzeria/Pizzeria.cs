using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {

        List<Employee> Employees { get; } = new List<Employee>();
        User User {get; set;}
        ShopAssistant shopAssistant { get; }
        Cook cook { get; set; }

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
        public void CreateEmpoyy(Pizzeria pizzeria)
        {
            pizzeria.CreateAdress("Belarus", "Minsk", "Yakeba Kolasa", "26");
            pizzeria.AddEmployy(new Administrator("Ivan"));
            pizzeria.AddEmployy(new Deliveryman("Egor"));
            pizzeria.AddEmployy(new ShopAssistant("Vlad"));
            pizzeria.AddEmployy(new Cook("Kirill"));
        }
        public void StartPizzeria(Pizzeria pizzeria)
        {
            CreateEmpoyy(pizzeria);
            Order order = User.UserEnterParam();
            shopAssistant.AcceptOrder(order, cook);
        }

    }
   
}