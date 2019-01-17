namespace Ecommerce
{
    internal class BillDesk : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            // The bank specific API call to make the payment
            System.Console.WriteLine("Using Bill Desk to pay for {0}, amount {1}", product.Name, product.Price);
        }
    }
}