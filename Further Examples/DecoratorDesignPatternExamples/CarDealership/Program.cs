using CarDealership.ConcreteComponents;
using CarDealership.ConcreteDecorators;
using System;

namespace CarDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic vehicle
            HondaCity car = new HondaCity();

            Console.WriteLine("Honda City base price are : {0}", car.Price);

            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25% discount";

            Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);

            Console.ReadKey();
        }
    }
}
