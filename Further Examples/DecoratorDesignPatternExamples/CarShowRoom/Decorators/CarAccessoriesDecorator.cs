using CarShowRoom.Components;

namespace CarShowRoom.Decorators
{
    /// <summary>
    /// Abstract Decorator
    /// </summary>
    public abstract class CarAccessoriesDecorator : ICar
    {
        ICar _car;

        public virtual double Cost { get { return _car.Cost; } }

        public virtual string Description { get { return _car.Description; } }

        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }
    }
}
