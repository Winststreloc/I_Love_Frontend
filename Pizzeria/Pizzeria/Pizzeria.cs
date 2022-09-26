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
            Adress AdressPizzeria = new Adress("Belarus", "Minsk", "Timirazeva", "67");
            Console.WriteLine("Name: {0} \nAdress: {1}", Name, AdressPizzeria.FullAdress);
        }
        public void ApplyOreder()
        {
            Adress adress_client = new Adress("Belarus", "Minsk", "Gromova", "22");
            Client client = new Client("Dima", adress_client);
            Order order = client.CreateOrder(client.Name, PizzaName.Cheese, PizzaSize.Large, false, adress_client);

            
        
        
        }
    }
   
}