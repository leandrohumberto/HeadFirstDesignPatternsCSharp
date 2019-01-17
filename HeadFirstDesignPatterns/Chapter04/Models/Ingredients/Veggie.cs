namespace Chapter04.Models.Ingredients
{
    public abstract class Veggie : IIngredient
    {
        public virtual string Name { get; } = "Veggie";

        public override string ToString()
        {
            return Name;
        }
    }
}
