using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Furnace:Equipment
    {
        public readonly string _name;
        public readonly int _inventory_number;
        private string Firm { get; set; }
        private int Power { get; set; }
        private int Capacity { get; set; }
        private double Cost { get; set; }
        private const double _tariff = 0.2;

        public Furnace(Equipment obj,string firm,int capacity)
        {
            _name = obj.name_of_equip;
            _inventory_number = obj.inventory_number;
            Firm = firm;
        }
        public double Electricity_costs(Furnace obj, double time)
        {
            double cost = obj.Power * time*_tariff;

            return cost;
        }
    }
}
