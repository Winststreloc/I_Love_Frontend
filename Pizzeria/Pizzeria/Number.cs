using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Number
    {
        public string CallNumber { get; set; }
        public void Call()
        {
            Console.WriteLine($"+{CallNumber}");
        } 
    }
}
