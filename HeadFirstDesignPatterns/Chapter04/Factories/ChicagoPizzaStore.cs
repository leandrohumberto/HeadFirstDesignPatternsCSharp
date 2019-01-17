using Chapter04.Models;

namespace Chapter04.Factories
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory, "Chicago Style Cheese Pizza");
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory, "Chicago Style Clam Pizza");
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
