using Chapter04.Factories;
using System;

namespace Chapter04.Models
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory factory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory, string name = "Cheese Pizza")
        {
            Name = name;
            factory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = factory.CreateDough();
            Console.WriteLine($"Added {Dough.Name}");
            Sauce = factory.CreateSauce();
            Console.WriteLine($"Added {Sauce.Name}");
            Cheese = factory.CreateCheese();
            Console.WriteLine($"Added {Cheese.Name}");
        }
    }
}
