using Chapter04.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04.Models
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _factory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory, string name = "Cheese Pizza")
        {
            Name = name;
            _factory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _factory.CreateDough();
            Console.WriteLine($"Added {Dough.Name}");
            Sauce = _factory.CreateSauce();
            Console.WriteLine($"Added {Sauce.Name}");
            Cheese = _factory.CreateCheese();
            Console.WriteLine($"Added {Cheese.Name}");
            Clams = _factory.CreateClam();
            Console.WriteLine($"Added {Clams.Name}");
        }
    }
}
