namespace Chapter03.Beverages
{
    public class DarkRoast : Beverage
    {
        public override string Description { get; } = "Dark Roast";

        public override double Cost
        {
            get { return .99; }
        }

        public DarkRoast(BeverageSize size) : base(size)
        {

        }
    }
}
