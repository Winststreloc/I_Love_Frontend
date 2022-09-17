using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {
        public string NumberPizzeria { get; set; }
        public string AdressPizzeria { get; set; }

        public void Advertisement()
        {
            Console.WriteLine($"Pleas visit to us at {AdressPizzeria} or call us by Phone Number{NumberPizzeria}");
        }
    }
}