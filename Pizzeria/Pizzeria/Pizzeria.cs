using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {
        public string Name { get; set; }
        public Pizzeria()
        {
            Name = "Defacto";
            Adress a = new Adress();
            a.Country = "Italy";
            a.Sity = " Rome";
            a.Street = " Via Veneto";
            a.Home = " 35";
            a.GiveAdress();
            Number b = new Number();
            b.CallNumber = 375298888888 ;

        }


       
    }
   
}