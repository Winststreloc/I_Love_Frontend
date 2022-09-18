using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class ShopAssistant : Employee
    {
        // public Order Order { get; set; }
        // private Cook _cook;
         public Cook Cook { get; set; }

        public void AcceptOrder(Order order)
        {
            Console.WriteLine("Order accepted");
            // SendOrderCook(order);
            //в классе Order должно быть свойство Pizza, в которой будет выбранная пицца
            var pizza = order.Pizza;
            Cook.CreatePizza(pizza);
        }
        //private void SendOrderCook(Order order)
        //{
        //    Cook.Order = order;//передали в свойства повара Order order
        //}

    }
}
