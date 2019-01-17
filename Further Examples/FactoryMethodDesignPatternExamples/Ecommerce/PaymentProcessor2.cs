namespace Ecommerce
{
    class PaymentProcessor2
    {
        IPaymentGateway gateway = null;

        public void MakePayment(PaymentMethod method, Product product)
        {
            var factory = new PaymentGatewayFactoryExtended();
            gateway = factory.CreatePaymentGateway(method, product);

            gateway.MakePayment(product);
        }
    }
}
