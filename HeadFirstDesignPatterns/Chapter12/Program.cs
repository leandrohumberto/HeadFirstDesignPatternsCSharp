using Chapter12.Adapters;
using Chapter12.Decorators;
using Chapter12.Ducks;
using Chapter12.Factories;
using System;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Simulate(new CountingDuckFactory());
        }

        private void Simulate(AbstractDuckFactory duckFactory)
        {
            Flock flockOfDucks = new Flock
            {
                duckFactory.CreateRedheadDuck(),
                duckFactory.CreateDuckCall(),
                duckFactory.CreateRubberDuck(),
                new GooseAdapter(new Geese.Goose())
            };

            Flock flockOfMallards = new Flock
            {
                duckFactory.CreateMallardDuck(),
                duckFactory.CreateMallardDuck(),
                duckFactory.CreateMallardDuck(),
                duckFactory.CreateMallardDuck(),
            };

            Console.WriteLine("\nDuck Simulator: With Observer");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.Subscribe(quackologist);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulator");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulator");
            Simulate(flockOfMallards);            

            Console.WriteLine("\nThe ducks quacked {0} times", QuackCounter.Count);
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
