using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    public class Client
    {
        //Location location { get; } //TODO
        List<Order> Orders { get; }
        public string Name { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public Order Get(int id)
        {
            return Orders.FirstOrDefault(p => p.Id == id);
        }
        public Order CreateOrder(string clientName, Pizza pizza, bool deliver)
        {
            Name = clientName;
            Order order = new Order(pizza, deliver, clientName);
            return order;
        }
        public void DeleteOrder(int id)
        {
            var order = Get(id);
            Orders.Remove(order);
        }

    }
}
