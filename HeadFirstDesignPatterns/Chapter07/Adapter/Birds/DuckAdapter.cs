namespace Chapter07.Birds
{
    class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;
        private readonly System.Random random = new System.Random();

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Fly()
        {
            if (random.Next(5) == 0)
                _duck.Fly();
        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
