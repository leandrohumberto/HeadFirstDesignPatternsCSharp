using OnlineOrdering.Facade;
using OnlineOrdering.Subsystem;
using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Creating the Order/Product details
            OrderDetails orderDetails = new OrderDetails("C# Design Pattern Book", "Simplified book on design patterns in C#",
                500, 10, "Street No 1", "Educational Area", 1212, "4156213754");

            // Using Facade
            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            facade.FinalizeOrder(orderDetails);

            #region Client Code without Facade.
            /*
            // Updating the inventory.
            IInventory inventory = new InventoryManager();
            inventory.Update(orderDetails.ProductNo);

            // Verfying various details for the order such as the shipping address.
            IOrderVerify orderVerify = new OrderVerificationManager();
            orderVerify.VerifyShippingAddress(orderDetails.PinCode);



            // Calculating the final cost after applying various discounts.
            ICosting costManger = new CostManager();
            orderDetails.Price = costManger.ApplyDiscounts(orderDetails.Price, orderDetails.DiscountPercent);

            // Going through various steps if payment gateway like card verification, charging from the card.
            IPaymentGateway paymentGateWay = new PaymentGatewayManager();
            paymentGateWay.VerifyCardDetails(orderDetails.CardNo);
            paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);

            // Completing the order by providing Logistics.
            ILogistics logistics = new LogisticsManager();
            logistics.ShipProduct(orderDetails.ProductName, string.Format("{0}, {1} - {2}.", orderDetails.AddressLine1, 
                orderDetails.AddressLine2, orderDetails.PinCode));
            */
            #endregion

            Console.ReadKey();
        }
    }
}
