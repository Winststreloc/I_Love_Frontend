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
            ShopAssistant assistant = new ShopAssistant("Ighar");
            Deliveryman deliverman = new Deliveryman();
            Cook cook = new Cook();
            Order order = client.CreateOrder(client.Name, PizzaName.Margherita, PizzaSize.Medium, true, clientLocation);
            
            assistant.AcceptOrder(order);

        } 
    }
}
