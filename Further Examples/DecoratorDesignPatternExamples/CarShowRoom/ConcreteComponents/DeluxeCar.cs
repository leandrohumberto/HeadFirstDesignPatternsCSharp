namespace CarShowRoom.ConcreteComponents
{
    /// <summary>
    /// Concrete car.
    /// </summary>
    public class DeluxeCar : Components.ICar
    {
        public double Cost { get; } = 750000;

        public string Description { get; } = "Deluxe Car";
    }
}
