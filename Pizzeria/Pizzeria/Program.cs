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

            Employee admin = new Administrator("Ivan");
            admin.Perekyr();

            Order order = client.CreateOrder(client.Name, PizzaName.Margherita, PizzaSize.Medium, false, clientLocation);
            
            var deliveryman = new Deliveryman { Client = client };
            deliveryman.Perekyr();
            var shopAssistant = new ShopAssistant("Igor") { Deliveryman = deliveryman };
            shopAssistant.AcceptOrder(order);
        } 
    }
}
