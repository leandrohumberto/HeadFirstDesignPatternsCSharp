using Chapter04.Models;

namespace Chapter04.Factories
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory, "New York Style Cheese Pizza");
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory, "New York Style Clam Pizza");
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
