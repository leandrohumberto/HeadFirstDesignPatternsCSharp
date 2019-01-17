using CreditCardGenerator.Products;

namespace CreditCardGenerator.Creators
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>
    class MoneyBackFactory : CardFactory
    {
        private decimal _creditLimit;
        private decimal _annualCharge;

        public MoneyBackFactory(decimal creditLimit, decimal annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override ICreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
