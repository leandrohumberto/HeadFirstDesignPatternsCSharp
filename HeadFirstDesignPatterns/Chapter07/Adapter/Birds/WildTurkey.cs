namespace Chapter07.Birds
{
    class WildTurkey : ITurkey
    {
        public void Fly()
        {
            System.Console.WriteLine("I'm flying a short distance");
        }

        public void Gobble()
        {
            System.Console.WriteLine("Gobble gobble");
        }
    }
}
