using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {
        public string Name { get; }
        public string AdressPizzeria { get; }
        public Pizzeria()
        {
            Name = "Little Italy";
            Adress AdressPizzeria = new Adress("Italy", "Romue", "Yacuba colasa", "35");
            Console.WriteLine(AdressPizzeria.FullAdress);
        } 
    }
   
}