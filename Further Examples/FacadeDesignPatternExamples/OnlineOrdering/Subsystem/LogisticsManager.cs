using System;

namespace OnlineOrdering.Subsystem
{
    interface ILogistics
    {
        void ShipProduct(string productName, string shippingAddress);
    }
    
    class LogisticsManager : ILogistics
    {
        public void ShipProduct(string productName, string shippingAddress)
        {
            Console.WriteLine("Congratulations your product {0} has been shipped at the following address: {1}", 
                productName, shippingAddress);
        }
    }
}
