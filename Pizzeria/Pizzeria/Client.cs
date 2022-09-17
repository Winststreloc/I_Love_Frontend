﻿using System;
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
            Orders = new List<Order>();
        }
        public Order Get(int id)
        {
            return Orders.FirstOrDefault(p => p.Id == id);
        }
        public void AddOrder(string name, Order order)
        {
            Name = name;
            order.Id += 1;
            Orders.Add(order);
        }
        public void DeleteOrder(int id)
        {
            var order = Get(id);
            Orders.Remove(order);
        }

    }
}
