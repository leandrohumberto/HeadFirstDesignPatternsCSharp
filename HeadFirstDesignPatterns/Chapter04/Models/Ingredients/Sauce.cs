namespace Chapter04.Models.Ingredients
{
    public abstract class Sauce : IIngredient
    {
        public virtual string Name { get; } = "Sauce";

        public override string ToString()
        {
            return Name;
        }
    }
}
