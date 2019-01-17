namespace Chapter03.Beverages
{
    public class Espresso : Beverage
    {
        public override string Description { get; } = "Espresso";

        public override double Cost
        {
            get { return 1.99; }
        }

        public Espresso(BeverageSize size) : base(size)
        {

        }
    }
}
