namespace CreditCardGenerator.Products
{
    interface ICreditCard
    {
        string CardType { get; }
        decimal CreditLimit { get; set; }
        decimal AnnualCharge { get; set; }
    }
}
