using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Cook : Employee
    {
        public Cook(string name)
        {
            Name = name;
        }
        private readonly List<Equipment> _equipments = new List<Equipment>
        {
            new Furnace("Furnace", 1),
            new Other_equip("Knife", 2)
        };

        public Pizza CreatePizza(PizzaName name, PizzaSize size)
        {
            foreach (var equipment in _equipments)
            {
                equipment.Show();
            }
            Pizza pizza = new Pizza(name, size);
            return pizza;
        }

    }
}
