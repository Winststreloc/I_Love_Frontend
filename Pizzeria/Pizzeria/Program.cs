using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria = new Pizzeria("Dominoz");
            pizzeria.StartPizzeria(pizzeria);
        } 
    }
}
