namespace CarFactory
{
    /// <summary>
    /// The swift car with additional features.
    /// </summary>
    sealed class SwiftCarFeatured : SwiftCar
    {
        /// <summary>
        /// Creates a Featured swift car with a color requested by the client.
        /// </summary>
        /// <param name="Color">The color of the featured swift car.</param>
        public SwiftCarFeatured(CarColor color) : base(color)
        {
        }

        /// <summary>
        /// Customised calculation of the car with additional features such as airbags, speakers, power window, etc.
        /// </summary>
        /// <returns>The price of the featured model of swift car.</returns>
        public override float CalculatePrice()
        {
            float basicPrice = 400000F;
            float otherEquipmentCosts = 200000F;
            return basicPrice + otherEquipmentCosts;
        }
    }
}
