using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Number
    {
        public long CallNumber { get; set; }
        public void Call()
        {
            Console.WriteLine($"+{CallNumber}");
        } 
    }
}
