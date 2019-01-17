using CarShowRoom.Components;
using CarShowRoom.Decorators;

namespace CarShowRoom.ConcreteDecorators
{
    /// <summary>
    /// Concrete decorator.
    /// </summary>
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public override string Description
        {
            get
            {
                return $"{base.Description}, Advanced Accessories Package";
            }
        }

        public override double Cost
        {
            get
            {
                return base.Cost + 10000;
            }
        }

        public AdvancedAccessories(ICar car) : base(car)
        {
        }
    }
}
