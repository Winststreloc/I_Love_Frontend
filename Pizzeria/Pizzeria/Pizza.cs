using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizza
    {
        public string Testo { get; set; }
        public PizzaSize PizzaSize { get; }
        public PizzaName PizzaName { get; }
        public Pizza()
        {
            
        }

    }

    public enum PizzaSize { Small, Medium, Large }
    public enum PizzaName { Pepperoni, Margherita, Cheese }
}
