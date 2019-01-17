using Chapter04.Factories;
using Chapter04.Models;
using System;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine("Ethan ordered a " + pizza.Name + "\n");
            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            Console.ReadKey();
        }
    }
}
