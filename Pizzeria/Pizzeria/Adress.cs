using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Adress
    {
        public string Country { get; set; }
        public string Sity { get; set; }
        public string Street { get; set; }
        public string Home {get; set;}
      
        public void GiveAdress()  
        {
            string fullAdress = Country + Sity + Street + Home;
            Console.WriteLine($"ADRESS {fullAdress}"); 
        }


    }
}

