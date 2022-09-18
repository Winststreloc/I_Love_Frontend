using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Order
    {
        private decimal Price { get; set; }

        //TODO private DateTime TimeCreateOrder { get; set; }

        public int Id { get; set; }
        public string ClientName { get; set; }
        public bool NeedDelivery { get; set; }


        public Order(PizzaSize size, PizzaName pizzaName, bool deliver, string clientName)
        {
            Id = 1;
            NeedDelivery = deliver;
            ClientName = clientName;
        }
    }
}
