using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Order
    {
        private decimal Price { get; set; }
        public int Id { get; set; }
        public string ClientName { get; set; }
        public bool NeedDelivery { get; set; }
        public Adress ClientLocation { get; }
        public PizzaName PizzaName { get; set; }
        public PizzaSize PizzaSize { get; set; }

        public Order(PizzaName pizzaName,PizzaSize pizzaSize, bool deliver, string clientName, Adress clientlocation)
        {
            Id = 0;
            PizzaName = pizzaName;
            PizzaSize = pizzaSize;
            NeedDelivery = deliver;
            ClientName = clientName;
            ClientLocation = clientlocation;
            Console.WriteLine("Your pizza will cost: {0} BYN", CreatePrice(pizzaSize, pizzaName));
            DateTime timecreateorder = DateTime.Now;
            Console.WriteLine($"Time create order: {timecreateorder}");
        }
        public double CreatePrice(PizzaSize size, PizzaName name)
        {
            return (((int)size) / 10) * (int)name;
        }
    }
}
