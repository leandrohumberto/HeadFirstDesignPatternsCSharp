namespace Ecommerce
{
    class PaymentGatewayFactoryExtended : PaymentGatewayFactory
    {
        public override IPaymentGateway CreatePaymentGateway(PaymentMethod paymentMethod, Product product)
        {
            IPaymentGateway gateway = null;

            switch (paymentMethod)
            {
                case PaymentMethod.PayPal:
                    gateway = new PayPal();
                    break;
                case PaymentMethod.BillDesk:
                    gateway = new BillDesk();
                    break;
                default:
                    gateway = base.CreatePaymentGateway(paymentMethod, product);
                    break;
            }

            return gateway;
        }
    }
}
