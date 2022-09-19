using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    public class Client
    {
        //TODOAdress location 
        List<Order> Orders { get; }
        public string Name { get; set; }
        public Client(string name)
        {
            Name = name;
            //TODO Location = location;
        }
        public Order Get(int id)
        {
            return Orders.FirstOrDefault(p => p.Id == id);
        }
        public Order CreateOrder(string clientName, PizzaName pizzaName, PizzaSize pizzaSize, bool deliver)
        {
            Name = clientName;
            Order order = new Order(pizzaName, pizzaSize, deliver, clientName);
            return order;
        }
        public void DeleteOrder(int id)
        {
            var order = Get(id);
            Orders.Remove(order);
        }

    }
}
