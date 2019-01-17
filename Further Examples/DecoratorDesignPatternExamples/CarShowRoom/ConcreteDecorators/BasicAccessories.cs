using CarShowRoom.Decorators;
using CarShowRoom.Components;

namespace CarShowRoom.ConcreteDecorators
{
    /// <summary>
    /// Concrete decorator.
    /// </summary>
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public override string Description
        {
            get
            {
                return $"{base.Description}, Basic Accessories Package";
            }
        }

        public override double Cost
        {
            get
            {
                return base.Cost + 2000;
            }
        }

        public BasicAccessories(ICar car) : base(car)
        {
        }
    }
}
