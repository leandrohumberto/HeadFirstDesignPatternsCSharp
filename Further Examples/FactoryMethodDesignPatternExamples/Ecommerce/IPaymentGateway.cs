namespace Ecommerce
{
    interface IPaymentGateway
    {
        void MakePayment(Product product);
    }
}
