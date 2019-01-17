namespace Chapter03.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverages.Beverage beverage) : base(beverage)
        {
        }

        public override double Cost
        {
            get { return beverage.Cost + .2; }
        }

        public override string Description
        {
            get { return beverage.Description + ", Mocha"; }
        }
    }
}
