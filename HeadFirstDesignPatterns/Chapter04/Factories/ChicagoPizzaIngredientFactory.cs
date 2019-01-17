using Chapter04.Models.Ingredients;

namespace Chapter04.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[] { new BlackOlives(), new EggPlant(), new Spinach(), };
        }
    }
}
