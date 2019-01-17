using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Program
    {
        static void Main(string[] args)
        {
            var boiler1 = ChocolateBoiler.Instance;
            var boiler2 = ChocolateBoiler.Instance;

            Console.WriteLine("Same object? {0}", boiler1 = boiler2);

            boiler1.Fill();
            Console.WriteLine("Is Empty? {0}", boiler2.Empty);

            boiler2.Boil();
            Console.WriteLine("Is Boiled? {0}", boiler1.Boiled);

            Console.ReadKey();
        }
    }
}
