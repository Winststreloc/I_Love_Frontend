using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class User
    {
        public List<Client> Users { get; } = new List<Client>();
        Pizza pizza { get; }

        public Order UserEnterParam()
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
            return UserCreateOrder(userTemp);


            //Console.WriteLine("okey, you want create order?");
            //string answer = Console.ReadLine();
        }

        public Order UserCreateOrder(Client user)
        {
            Console.WriteLine("Enter pizza name");
            string pizzaName = Console.ReadLine();
            while (pizzaName != "cheese" || pizzaName != "pepperoni" || pizzaName != "margherita")
            {
                pizzaName = Console.ReadLine();
            }
            Console.WriteLine("Enter pizza size");
            string pizzaSize = Console.ReadLine();
            while (pizzaSize != "medium" || pizzaSize != "small" || pizzaSize != "large")
            {
                pizzaSize = Console.ReadLine();
            }
            Console.WriteLine("You need delivery?");
            Adress userLocation = default;
            if (user.Adress == null)
            {
                userLocation = ExamUserDelivery(user);
            }
            else
            {
                userLocation = user.Adress;
            }
            bool _needDelivery = Console.ReadLine() == "yes" ? true : false;
            (PizzaName, PizzaSize) paramPizza = pizza.ReturnParamOfPizza(pizzaName, pizzaSize);
            Order order = user.CreateOrder(user.Name, paramPizza.Item1, paramPizza.Item2, _needDelivery, userLocation);
            return order;
        }
        public Adress ExamUserDelivery(Client user)
        {
            Console.WriteLine("Plese, enter you Adress");
            Adress _userLocation = new Adress(Console.ReadLine());
            return _userLocation;

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
