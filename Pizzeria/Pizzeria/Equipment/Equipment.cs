using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Equipment
    {
        private readonly string name_of_equip;
        private readonly int inventory_number;
        private readonly DateTime _commusing;
        public Equipment(string name, int number)
        {
            name_of_equip = name;
            inventory_number = number;
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
            Console.WriteLine($"name of equipment {name_of_equip}; inventory number {inventory_number}; Time {DateTime.Now}");
        }

        public Equipment() { }
    }
}
