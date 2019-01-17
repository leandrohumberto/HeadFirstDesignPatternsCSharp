using CreditCardGenerator.Products;

namespace CreditCardGenerator.Creators
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>
    class TitaniumFactory : CardFactory
    {
        private decimal _creditLimit;
        private decimal _annualCharge;

        public TitaniumFactory(decimal creditLimit, decimal annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override ICreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
