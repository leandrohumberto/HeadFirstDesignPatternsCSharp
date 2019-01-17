namespace CarDealership.ConcreteComponents
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class HondaCity : Components.IVehicle
    {
        public string Make { get; } = "Honda";

        public string Model { get; } = "Civic";

        public double Price { get; } = 40000;
    }
}
