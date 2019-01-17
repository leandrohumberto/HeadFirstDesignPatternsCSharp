namespace Chapter04.Models.Ingredients
{
    public abstract class Clams : IIngredient
    {
        public virtual string Name { get; } = "Clam";

        public override string ToString()
        {
            return Name;
        }
    }
}
