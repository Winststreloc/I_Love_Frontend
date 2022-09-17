using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Order
    {
        private decimal Price { get; set; }

        private DateTime TimeCreateOrder { get; set; }

        public int Id { get; set; }
        public PizzaSize PizzaSize { get; }
        public string ClientName { get; set; }
        public PizzaName PizzaName { get;}
        public bool NeedDelivery { get; set; }


        public Order(int id, string name, PizzaSize size, PizzaName pizzaName, bool deliver,  DateTime time, decimal price, string clientName)
        {
            Id = id;
            PizzaSize = size;
            PizzaName = pizzaName;
            NeedDelivery = deliver;
            TimeCreateOrder = time;
            Price = price;
            ClientName = clientName;
        }



    }
}
