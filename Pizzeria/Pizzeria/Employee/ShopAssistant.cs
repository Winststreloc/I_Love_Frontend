using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class ShopAssistant : Employee
    {
        /*
        in Program

        Client client = new Client();
        Deliveryman deliveryman = new Deliveryman{Client=client};
        ShopAssiistant assistant = new ShopAssistant{Deliveryman=deliveryman};
        */
        public List<Order> Orders { get; } = new List<Order>();
        public Cook Cook { get; set; } = new Cook();
        public Deliveryman Deliveryman { get; set; } 
        public ShopAssistant(string name)
        {
            Name = name;
        }

        public void AcceptOrder(Order order)
        {
            order.Id += 1;
            Orders.Add(order);
            Console.WriteLine("Order accepted");
            Cook.CreatePizza(order.PizzaName, order.PizzaSize);

            if(order.NeedDelivery)
            {
                Deliveryman.Deliver(order.);
            }
            else
            {
                Console.WriteLine("Order ready! Take your order!");
            }
           
        }
    }
}
