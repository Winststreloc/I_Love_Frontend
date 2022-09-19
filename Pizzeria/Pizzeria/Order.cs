﻿using System;
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
        }
    }
}
