﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Order
    {
        private decimal Price { get; set; }   
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsGlutenFree { get; set; }

        public Order()
        {

        }



    }
}