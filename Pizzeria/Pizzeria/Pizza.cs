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
        public Pizza(PizzaName pizzaName, PizzaSize pizzaSize)
        {
            PizzaName = pizzaName;
            PizzaSize = pizzaSize;
            Testo = "normal";
        }

    }

    public enum PizzaSize
    {
        Small = 8,
        Medium = 12,
        Large = 16
    }
    public enum PizzaName
    {
        Pepperoni = 10,
        Margherita = 13,
        Cheese = 9
    }
}
