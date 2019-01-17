namespace CarFactory
{
    interface ISwiftCarFactory
    {
        SwiftCar CreateSwiftCar(SwiftCarType carType, CarColor carColor);
    }
}