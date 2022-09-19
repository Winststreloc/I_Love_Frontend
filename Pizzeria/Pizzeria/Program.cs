using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria = new Pizzeria();
            Adress clientLocation = new Adress("Belarus", "Minsk", "Yakuba Kolasa", "26");
            Client client = new Client("Ivan", clientLocation);
            Order order = client.CreateOrder(client.Name, PizzaName.Margherita, PizzaSize.Medium, true);
            ShopAssistant assistant = new ShopAssistant("Ighar");
            assistant.AcceptOrder(order);

        } 
    }
}
