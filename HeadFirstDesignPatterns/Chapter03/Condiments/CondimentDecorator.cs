namespace Chapter03.Condiments
{
    public abstract class CondimentDecorator : Beverages.Beverage
    {
        protected Beverages.Beverage beverage;

        public CondimentDecorator(Beverages.Beverage beverage) : base(beverage.Size)
        {
            this.beverage = beverage;
        }
    }
}
