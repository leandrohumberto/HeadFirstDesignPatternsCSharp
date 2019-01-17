using Chapter04.Models.Ingredients;
using System;
using System.Collections.Generic;

namespace Chapter04.Models
{
    public abstract class Pizza
    {
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Veggie[] Veggies { get; set; }
        protected Cheese Cheese { get; set; }
        protected Pepperoni Pepperoni { get; set; }
        protected Clams Clams { get; set; }

        public string Name { get; protected set; } = "Pizza";

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }

    public enum PizzaType
    {
        Cheese,
        Clam,
    }
}
