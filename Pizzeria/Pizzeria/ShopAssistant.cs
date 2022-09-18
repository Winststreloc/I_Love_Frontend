using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class ShopAssistant : Employee
    {
        /*
        in Program

        Client client = new Client();
        Deliveryman deliveryman = new Deliveryman{Client=client};
        ShopAssiistant assistant = new ShopAssistant{Deliveryman=deliveryman};
        */
        public Cook Cook { get; set; } = new Cook();
        public Deliveryman Deliveryman { get; set; } 

        public void AcceptOrder(Order order)
        {
            Console.WriteLine("Order accepted");
            //в классе Order должно быть свойство Pizza, в которой будет выбранная пицца
            var pizza = Cook.CreatePizza(order.Pizza);
            Deliveryman.Deliver(pizza);
        }
    }
}
