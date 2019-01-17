using System;

namespace OnlineOrdering.Subsystem
{
    class OrderDetails
    {
        public int ProductNo { get; private set; }
        public string ProductName { get; private set; }
        public string ProductDescription { get; private set; }
        public float Price { get; set; }
        public float DiscountPercent { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public int PinCode { get; private set; }
        public string CardNo { get; private set; }

        public OrderDetails(string productName, string prodDescription, float price, float discount, 
            string addressLine1, string addressLine2, int pinCode, string cardNo)
        {
            ProductNo = new Random(1).Next(1, 100);
            ProductName = productName;
            ProductDescription = prodDescription;
            Price = price;
            DiscountPercent = discount;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            PinCode = pinCode;
            CardNo = cardNo;
        }
    }
}
