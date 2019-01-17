namespace PrimeNumbers
{
    class PrimeSolverToPrimeDirectiveAdapter : IPrimeDirective, IPrimeDirectiveAdapter
    {
        private readonly PrimeSolver _primeSolver;

        public PrimeSolverToPrimeDirectiveAdapter()
        {
            _primeSolver = new PrimeSolver();
        }

        public int FindNearestPrime(int number)
        {
            return _primeSolver.CalculatePrime(number);
        }
    }
}
