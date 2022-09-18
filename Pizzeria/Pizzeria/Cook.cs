using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Cook : Employee
    {
        private Pizza _pizza = new Pizza();
        //public Order Order { get; set; }
        private readonly List<Equipments> _equipments = new List<Equipments>
        {
            new Furnace(), 
            //еще наследники класса Equipments
        };
        public void CreatePizza(Pizza pizza)
        {
            //Надо знать методы Equipment
            foreach (var equipment in _equipments)
            {
                equipment.Use(pizza);
            }

        }

    }
}
