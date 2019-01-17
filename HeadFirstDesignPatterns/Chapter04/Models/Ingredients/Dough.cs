namespace Chapter04.Models.Ingredients
{
    public abstract class Dough : IIngredient
    {
        public virtual string Name { get; } = "Dough";

        public override string ToString()
        {
            return Name;
        }
    }
}
