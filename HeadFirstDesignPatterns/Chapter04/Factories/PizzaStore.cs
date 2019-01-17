using Chapter04.Models;

namespace Chapter04.Factories
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}
