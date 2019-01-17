namespace BuilderExamples.Builders
{
    public interface IFluentBuilder<T>
    {
        T Begin();
        T Engine { get; }
        T Tire();
        T SteeringWheels { get; }
        Product Build();
    }
}
