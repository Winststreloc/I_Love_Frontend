using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Adress
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home {get; set;}
        public string FullAdress => Country + " " + City + " " + Street + " " + Home;
        public Adress(string country,string city,string street,string home)
        {
            Country = country;
            City = city;
            Street = street;
            Home = home;
        }
            public Adress(string street)
        {
            Street = street;
        
        
        }
        public Adress CreateAdress(string country, string city, string street, string home)
        {
            return new Adress(country, city, street, home);
        }
    }
}

