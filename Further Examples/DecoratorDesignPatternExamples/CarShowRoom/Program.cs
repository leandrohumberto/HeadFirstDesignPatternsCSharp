using CarShowRoom.Components;
using CarShowRoom.ConcreteComponents;
using CarShowRoom.ConcreteDecorators;
using CarShowRoom.Decorators;
using System;

namespace CarShowRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            // Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            // Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.Write("Car Details: " + objAccessoriesDecorator.Description);
            Console.WriteLine(Environment.NewLine);
            Console.Write("Total Price: " + objAccessoriesDecorator.Cost);

            Console.ReadKey();
        }
    }
}
