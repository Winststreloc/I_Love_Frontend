using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class ShopAssistant : Employee
    {
        public List<Order> Orders { get; } = new List<Order>();
        public Deliveryman Deliveryman { get; set; } 
        public ShopAssistant(string name)
        {
            Name = name;
        }

        public void AcceptOrder(Order order, Cook cook)
        {
            order.Id += 1;
            Orders.Add(order);
            Console.WriteLine("Order accepted");
            Cook cook1 = cook;
            Pizza pizza = cook.CreatePizza(order.PizzaName, order.PizzaSize);

            if(order.NeedDelivery)
            {
                Deliveryman.Deliver(pizza, order.ClientName, order.ClientLocation); 
            }
            else
            {
                Console.WriteLine("Order ready! Take your order!");
            }
           
        }
    }
}
