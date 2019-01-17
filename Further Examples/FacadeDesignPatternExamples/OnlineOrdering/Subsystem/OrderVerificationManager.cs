using System;

namespace OnlineOrdering.Subsystem
{
    interface IOrderVerify
    {
        bool VerifyShippingAddress(int pincode);
    }

    class OrderVerificationManager : IOrderVerify
    {

        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine(string.Format("The product can be shipped to the pincode {0}.", pincode));
            return true;
        }
    }
}
