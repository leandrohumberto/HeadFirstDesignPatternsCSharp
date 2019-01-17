namespace Ecommerce
{
    class PaymentProcessor
    {
        IPaymentGateway gateway = null;

        public void MakePayment(PaymentMethod method, Product product)
        {
            PaymentGatewayFactory factory = new PaymentGatewayFactory();
            gateway = factory.CreatePaymentGateway(method, product);

            gateway.MakePayment(product);
        }
    }
}
