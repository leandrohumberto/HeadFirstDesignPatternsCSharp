namespace CarFactory
{
    /// <summary>
    /// Abstract class for swift car.
    /// </summary>
    abstract class SwiftCar
    {
        /// <summary>
        /// Color of the Swift car.
        /// </summary>
        public CarColor Color { get; }

        public SwiftCar(CarColor color)
        {
            Color = color;
        }

        /// <summary>
        /// Calculates the price of the swift car.
        /// </summary>
        /// <returns>Calculated Price.</returns>
        public abstract float CalculatePrice();
    }
}
