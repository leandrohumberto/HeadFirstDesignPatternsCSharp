using Chapter08.DotNetExample;
using Chapter08.WithHookTemplate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USING INHERITANCE");
            Console.WriteLine("---------------------------------------------------");
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();
            Console.WriteLine("\nMaking tea...");
            teaHook.PrepareRecipe();
            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();

            Duck[] ducks = 
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("\n\n.NET EXAMPLE (ORDERING ARRAYS)");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\nBefore sorting:");
            Display(ducks);
            Array.Sort(ducks);
            Console.WriteLine("\nAfter sorting:");
            Display(ducks);
            Console.ReadKey();
        }

        private static void Display(IEnumerable<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
