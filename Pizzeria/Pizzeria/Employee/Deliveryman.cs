using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Deliveryman: Employee
    {
        public Client Client { get; set; }
        public void Deliver(Pizza pizza, string clientName, Adress location)
        {
            Console.WriteLine($"order {pizza.PizzaName} send to {clientName} to adress {location}.");
        }
    }
}
