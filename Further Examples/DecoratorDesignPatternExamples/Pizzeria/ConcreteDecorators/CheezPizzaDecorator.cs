using Pizzeria.Decorators;
using Pizzeria.Components;

namespace Pizzeria.ConcreteDecorators
{
    public class CheezPizzaDecorator : Decorator
    {
        double _price;

        public CheezPizzaDecorator(Pizza basePizza) : base(basePizza)
        {
            _price = 100;
        }

        public override double Price { get { return base.Price + _price; } }
    }
}
