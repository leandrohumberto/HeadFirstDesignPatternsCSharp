using CarManufacturer.Facade;
using System;

namespace CarManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
