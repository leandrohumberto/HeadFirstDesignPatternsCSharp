namespace Chapter03.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverages.Beverage beverage) : base(beverage)
        {
        }

        public override double Cost
        {
            get { return beverage.Cost + .15; }
        }

        public override string Description
        {
            get { return beverage.Description + ", Soy"; }
        }
    }
}
