using System;

namespace Chapter07.Birds
{
    static class TestDrive
    {
        public static void Run()
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);
            var duckAdapter = new DuckAdapter(duck);
            Console.WriteLine("The Turkey says...");
            TestTurkey(turkey);
            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);
            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
            Console.WriteLine("\nThe DuckAdapter says...");
            TestTurkey(duckAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }

        private static void TestTurkey(ITurkey turkey)
        {
            turkey.Gobble();
            turkey.Fly();
        }
    }
}
