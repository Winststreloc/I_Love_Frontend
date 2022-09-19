using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Other_equip:Equipment
    {
        private string Type { get; set;}
        private decimal Value { get; set; }
        public Other_equip(string name, int number) : base(name, number)
        {

        }
        public Other_equip(decimal value,string type)
        {
            Type = type;
            Value = value;
        }

        
    }
}
