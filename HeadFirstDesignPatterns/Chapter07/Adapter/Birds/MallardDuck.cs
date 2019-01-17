namespace Chapter07.Birds
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            System.Console.WriteLine("I'm flying");
        }

        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}
