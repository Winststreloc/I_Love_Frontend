using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Deliveryman: Employee
    {
        /*
        in Program

        Client client = new Client();
        Deliveryman deliveryman = new Deliveryman(){Client=client};
        */
        public Client Client { get; set; }
        public void Deliver(Pizza pizza)
        {
            Console.WriteLine($"order {pizza.Name}send to {Client.Name} to adress {Client.Location}");
        }
    }
}
