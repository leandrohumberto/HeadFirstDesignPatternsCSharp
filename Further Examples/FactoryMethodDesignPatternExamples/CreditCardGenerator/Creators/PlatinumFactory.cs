using CreditCardGenerator.Products;

namespace CreditCardGenerator.Creators
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>
    class PlatinumFactory : CardFactory
    {
        private decimal _creditLimit;
        private decimal _annualCharge;

        public PlatinumFactory(decimal creditLimit, decimal annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override ICreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
