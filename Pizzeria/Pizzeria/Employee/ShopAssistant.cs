using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class ShopAssistant : Employee
    {
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
            var pizza = Cook.CreatePizza(order.PizzaName, order.PizzaSize);

            if(order.NeedDelivery)
            {
                Deliveryman.Deliver(pizza);
            }
            else
            {
                Console.WriteLine("Order ready! Take your order!");
            }
           
        }
    }
}
