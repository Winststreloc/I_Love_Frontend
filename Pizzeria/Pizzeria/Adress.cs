using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Adress
    {
        public string CustumerAdress { get; set; }
        public void Delivery()
        {
            Console.WriteLine($"Delivery order to {CustumerAdress}");
        }


    }
}

