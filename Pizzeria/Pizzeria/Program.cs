using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria = new Pizzeria("Dominoz");
            pizzeria.CreateAdress("Belarus", "Minsk", "Yakeba Kolasa", "26");
            pizzeria.AddEmployy(new Administrator("Ivan"));
            pizzeria.AddEmployy(new Deliveryman("Egor"));
            pizzeria.AddEmployy(new ShopAssistant("Vlad"));
            pizzeria.AddEmployy(new Cook("Kirill"));
            pizzeria.UserEnterParam();
            

            Adress clientLocation = new Adress("Belarus", "Minsk", "Yakuba Kolasa", "26");
            Client client = new Client("Ivan", clientLocation);


            Order order = client.CreateOrder(client.Name, PizzaName.Margherita, PizzaSize.Medium, false, clientLocation);
            
        } 
    }
}
