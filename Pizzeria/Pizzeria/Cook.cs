﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Cook : Employee
    {
        private readonly List<Equipments> _equipments = new List<Equipments>
        {
            //new Furnace(), 
            //еще наследники класса Equipments
        };
        public Pizza CreatePizza(Pizza pizza)
        {
            //Надо знать методы Equipment
            foreach (var equipment in _equipments)
            {
                //должен быть метод Use в во все наследниках классе Equipment
                equipment.Use(pizza);
            }
            
            return pizza;
        }

    }
}
