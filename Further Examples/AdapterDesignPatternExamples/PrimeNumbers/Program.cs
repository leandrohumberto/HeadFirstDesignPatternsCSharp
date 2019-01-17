using System;

namespace PrimeNumbers
{
    /// <summary>
    /// SOurce: https://visualstudiomagazine.com/articles/2013/10/11/the-adapter--pattern-in-dotnet.aspx.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var primeDirective = new PrimeSolverToPrimeDirectiveAdapter();
            Console.Write("Enter a number to find its nearest prime: ");
            int.TryParse(Console.ReadLine(), out int num);
            int result = primeDirective.FindNearestPrime(num);
            Console.WriteLine("The nearest prime to {0} is {1}.", num, result);
            Console.ReadKey();
        }
    }
}
