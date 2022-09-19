using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Equipment
    {
        public readonly string name_of_equip;
        public readonly int inventory_number;
        private readonly DateTime _commusing;
        private int k = 0;
        public Equipment(string name, DateTime a)
        {
            k++;
            name_of_equip = name;
            inventory_number = k;
            _commusing = a;
        }
        public void Show(string name_of_equip)
        {
            Console.WriteLine($"{name_of_equip}: {inventory_number}  {_commusing}");
        }
        public void Show(int invetor_num)
        {
            Console.WriteLine($"{inventory_number}: {name_of_equip}  {_commusing}");
        }
        public void Show()
        {
            Console.WriteLine($"{name_of_equip}: {inventory_number}  {_commusing}");
        }

        public Equipment() { }
    }
}
