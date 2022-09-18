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
        List<Order> Orders { get; }
        public Cook Cook { get; set; } = new Cook();
        public Deliveryman Deliveryman { get; set; } 
        public ShopAssistant(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AcceptOrder(Order order)
        {
            order.Id += 1;
            Orders.Add(order);
            Console.WriteLine("Order accepted");
            //Deliveryman.Deliver();
        }
    }
}
