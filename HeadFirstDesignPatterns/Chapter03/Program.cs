using Chapter03.Beverages;
using Chapter03.Condiments;
using System;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso(BeverageSize.Grande);
            Console.WriteLine(beverage.Description + " $" + beverage.Cost);

            Beverage beverage2 = new DarkRoast(BeverageSize.Tall);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost);

            Beverage beverage3 = new HouseBlend(BeverageSize.Venti);
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost);

            Console.ReadKey();
        }
    }
}
