using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Cook : Employee
    {
        private readonly List<Equipment> _equipments = new List<Equipment>
        {
            new Furnace(),
            new Other_equip()//TODO
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
