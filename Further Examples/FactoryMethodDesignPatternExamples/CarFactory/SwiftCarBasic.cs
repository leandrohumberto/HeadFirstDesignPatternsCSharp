namespace CarFactory
{
    /// <summary>
    /// The basic swift car.
    /// </summary>
    sealed class SwiftCarBasic : SwiftCar
    {
        /// <summary>
        /// Creates a basic swift car of defined color.
        /// </summary>
        /// <param name="color">The color requested by the client.</param>
        public SwiftCarBasic(CarColor color) : base(color)
        {
        }

        /// <summary>
        /// Customised calculation of price.
        /// </summary>
        /// <returns>The price of the basic model of swift car.</returns>
        public override float CalculatePrice()
        {
            float basicPrice = 400000F;
            return basicPrice;
        }
    }
}
