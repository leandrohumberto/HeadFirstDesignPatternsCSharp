namespace CarShowRoom.ConcreteComponents
{
    /// <summary>
    /// Concrete car.
    /// </summary>
    public class LuxuryCar : Components.ICar
    {
        public double Cost { get; } = 1000000;

        public string Description { get; } = "Luxury Car";
    }
}
