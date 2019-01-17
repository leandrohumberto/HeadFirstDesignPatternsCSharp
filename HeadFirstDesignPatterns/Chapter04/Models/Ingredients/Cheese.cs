namespace Chapter04.Models.Ingredients
{
    public abstract class Cheese : IIngredient
    {
        public virtual string Name { get; } = "Cheese";

        public override string ToString()
        {
            return Name;
        }
    }
}
