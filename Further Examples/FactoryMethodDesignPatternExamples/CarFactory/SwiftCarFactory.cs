namespace CarFactory
{
    /// <summary>
    /// The Class represents the Factory of the Swift Car.
    /// </summary>
    class SwiftCarFactory : ISwiftCarFactory
    {
        /// <summary>
        /// The method creates a swift car as desired by the consumer.
        /// </summary>
        /// <param name="carType">The car type specified by the Consumer.</param>
        /// <param name="carColor">The color  of the car specified by the consumer.</param>
        /// <returns>The desired swift car.</returns>
        public SwiftCar CreateSwiftCar(SwiftCarType carType, CarColor carColor)
        {
            SwiftCar car = null;

            switch (carType)
            {
                case SwiftCarType.Basic:
                    car = new SwiftCarBasic(carColor);
                    break;
                case SwiftCarType.Featured:
                    car = new SwiftCarFeatured(carColor);
                    break;
            }

            return car;
        }
    }
}