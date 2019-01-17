namespace Chapter03.Beverages
{
    public abstract class Beverage
    {
        public BeverageSize Size { get; set; }

        public virtual string Description { get; } = "Unknown beverage";

        public abstract double Cost { get; }

        public Beverage(BeverageSize size)
        {
            Size = size;
        }
    }

    public enum BeverageSize
    {
        Tall, 
        Grande, 
        Venti, 
    }
}
