using Pizzeria.Components;
using Pizzeria.ConcreteComponents;
using Pizzeria.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            var thikCrust = new ThikCrust();
            PizzaPriceInfo(thikCrust);

            var onionPizza = new OnionPizzaDecorator(thikCrust);
            PizzaPriceInfo(onionPizza);

            var cheezPizza = new CheezPizzaDecorator(onionPizza);
            PizzaPriceInfo(cheezPizza);

            Console.ReadKey();
        }

        static void PizzaPriceInfo(Pizza pizza)
        {
            Console.WriteLine("Price of pizza named '{0}' is {1}", pizza.ToString().Split('.')[2].ToString(), 
                pizza.Price);
        }
    }
}
