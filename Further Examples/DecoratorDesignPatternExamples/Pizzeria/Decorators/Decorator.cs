using Pizzeria.Components;

namespace Pizzeria.Decorators
{
    public abstract class Decorator : Pizza
    {
        private Pizza _basePizza;

        public override double Price { get { return _basePizza.Price; } }

        protected Decorator(Pizza basePizza)
        {
            _basePizza = basePizza;
        }
    }
}
