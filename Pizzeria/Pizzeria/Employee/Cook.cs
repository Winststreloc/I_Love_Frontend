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
            new Other_equip()
        };
        public Pizza CreatePizza(Pizza pizza)
        {
            foreach (var equipment in _equipments)
            {
                equipment.Show();
            }

            return pizza;
        }

    }
}
