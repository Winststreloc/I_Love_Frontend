using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzaService
    {
        List<Pizza> Pizzas { get; }
        static int nextId = 0;
        public PizzaService()
        {
            Pizzas = new List<Pizza>();
        }

        public void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }
    }
}
