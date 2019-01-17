namespace CreditCardGenerator.Creators
{
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>
    abstract class CardFactory
    {
        public abstract Products.ICreditCard  GetCreditCard();
    }
}
