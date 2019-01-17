namespace Chapter04.Models.Ingredients
{
    public abstract class Pepperoni : IIngredient
    {
        public virtual string Name { get; } = "Pepperoni";

        public override string ToString()
        {
            return Name;
        }
    }
}
