﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Adress
    {
        public string Country { get; set; }
        public string Сity { get; set; }
        public string Street { get; set; }
        public string Home {get; set;}
        public string FullAdress { get; }
        public Adress(string country,string sity,string street,string home)
        {
            Country = country;
            Сity = sity;
            Street = street;
            Home = home;
            FullAdress = country + sity + street + home;
        }
    }
}

