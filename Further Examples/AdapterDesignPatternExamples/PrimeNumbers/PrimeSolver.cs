using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers
{
    public class PrimeSolver : IPrimeSolver
    {
        public int CalculatePrime(int number)
        {
            var primes = Primes(number);
            return primes.Max();
        }

        /// <summary>
        /// Code from http://www.codeproject.com/Tips/257269/Find-Prime-Numbers-in-Csharp-Quickly?msg=4199032#xx4199032xx.
        /// </summary>
        /// <param name="bound"></param>
        /// <returns></returns>
        private IEnumerable<int> Primes(int bound)
        {
            if (bound < 2)
                yield break;
            
            //The first prime number is 2
            yield return 2;

            //Create a sieve of 'half size' starting at 3
            var notPrime = new BitArray((bound - 1) >> 1);
            int limit = ((int)(Math.Sqrt(bound)) - 1) >> 1;

            for (int i = 0; i < limit; i++)
            {
                if (notPrime[i])
                    continue;

                //The first number not crossed out is prime
                int prime = 2 * i + 3;
                yield return prime;

                //cross out all multiples of this prime, starting at the prime squared
                for (int j = (prime * prime - 2) >> 1; j < notPrime.Count; j += prime)
                {
                    notPrime[j] = true;
                }
            }

            //The remaining numbers not crossed out are also prime
            for (int i = limit; i < notPrime.Count; i++)
            {
                if (!notPrime[i])
                    yield return 2 * i + 3;
            }
        }
    }
}
