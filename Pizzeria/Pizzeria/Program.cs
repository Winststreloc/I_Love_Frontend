using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopAssistant assistant = new ShopAssistant("Egor");
            Client client = new Client("Anton");
            assistant.AcceptOrder(client.CreateOrder(client.Name, PizzaSize.Small, PizzaName.Pepperoni, false));

        } 
    }
}
