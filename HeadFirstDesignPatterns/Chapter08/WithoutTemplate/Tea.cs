using System;

namespace Chapter08.WithoutTemplate
{
    public class Tea
    {
        void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
