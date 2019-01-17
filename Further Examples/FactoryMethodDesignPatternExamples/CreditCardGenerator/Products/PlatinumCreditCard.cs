// With C# 7 features
namespace CreditCardGenerator.Products
{
    /// <summary>  
    /// A 'ConcreteProduct' class.
    /// </summary>
    class PlatinumCreditCard : ICreditCard
    {
        private readonly string _cardType;
        private decimal _creditLimit;
        private decimal _annualCharge;

        public string CardType => _cardType;

        public decimal CreditLimit { get => _creditLimit; set => _creditLimit = value; }
        public decimal AnnualCharge { get => _annualCharge; set => _annualCharge = value; }

        public PlatinumCreditCard(decimal creditLimit, decimal annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
    }
}
