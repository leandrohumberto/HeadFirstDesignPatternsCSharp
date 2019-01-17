namespace Ecommerce
{
    class PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(PaymentMethod paymentMethod, Product product)
        {
            IPaymentGateway gateway = null;

            switch (paymentMethod)
            {
                case PaymentMethod.BankOne:
                    gateway = new BankOne();
                    break;
                case PaymentMethod.BankTwo:
                    gateway = new BankTwo();
                    break;
                case PaymentMethod.BestForMe:
                    if (product.Price < 50)
                    {
                        gateway = new BankTwo();
                    }
                    else
                    {
                        gateway = new BankOne();
                    }
                    break;
                default:
                    break;
            }

            return gateway;
        }
    }
}
