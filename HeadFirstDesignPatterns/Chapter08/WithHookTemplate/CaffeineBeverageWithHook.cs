using System;

namespace Chapter08.WithHookTemplate
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (CustomerWantsCondiment())
            {
                AddCondiments();
            }
        }

        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiment() => true;

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void Brew();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}
