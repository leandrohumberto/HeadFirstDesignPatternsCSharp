using Pizzeria.Decorators;
using Pizzeria.Components;

namespace Pizzeria.ConcreteDecorators
{
    public class OnionPizzaDecorator : Decorator
    {
        double _price;

        public OnionPizzaDecorator(Pizza basePizza) : base(basePizza)
        {
            _price = 300;
        }

        public override double Price { get { return base.Price + _price; } }
    }
}
