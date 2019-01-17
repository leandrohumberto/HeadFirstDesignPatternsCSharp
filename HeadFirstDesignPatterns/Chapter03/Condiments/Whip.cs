namespace Chapter03.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverages.Beverage beverage) : base(beverage)
        {
        }

        public override double Cost
        {
            get { return beverage.Cost + .1; }
        }

        public override string Description
        {
            get { return beverage.Description + ", Whip"; }
        }
    }
}
