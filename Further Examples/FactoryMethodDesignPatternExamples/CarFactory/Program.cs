using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SwiftCarFactory();

            // The basic Swift car of Blue color -Creation
            var blueBasicSwiftCar = factory.CreateSwiftCar(SwiftCarType.Basic, CarColor.Blue);

            // Computation of Price
            float blueBasicSwiftCarPrice = blueBasicSwiftCar.CalculatePrice();
            Console.WriteLine("Price of Blue Basic Swift car {0}", blueBasicSwiftCarPrice);

            // The Red Featured Swift car of Blue color -Creation
            var redFeaturedSwiftCar = factory.CreateSwiftCar(SwiftCarType.Featured, CarColor.Red);

            // Computation of Price
            float redFeaturedSwiftCarPrice = redFeaturedSwiftCar.CalculatePrice();
            Console.WriteLine("Price of  Red Featured Swift car {0}", redFeaturedSwiftCarPrice);

            Console.ReadKey();
        }
    }
}
