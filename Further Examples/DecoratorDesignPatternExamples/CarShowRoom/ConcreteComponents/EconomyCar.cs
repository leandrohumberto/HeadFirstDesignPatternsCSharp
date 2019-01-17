namespace CarShowRoom.ConcreteComponents
{
    /// <summary>
    /// Concrete car.
    /// </summary>
    public class EconomyCar : Components.ICar
    {
        public string Description { get; } = "Economy Car";

        public double Cost { get; } = 450000;
    }
}
