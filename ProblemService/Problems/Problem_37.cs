using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_37 : Problem
    {
        //https://projecteuler.net/problem=37 Published on Friday, 14th February 2003, 06:00 pm; Solved by 63239;  Difficulty rating: 5%
        //                                      
        // The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right,
        //  and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
        //
        // Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
        //
        // NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var truncPrimes = new List<int>();
            var primes = new List<int>(_calc.GetAllPrimes(max));

            // ignoring first 4
            for (var i = 4; i < primes.Count(); i++)
                if (IsLeftTruncPrime(primes[i]) && IsRightTruncPrime(primes[i]))
                    truncPrimes.Add(primes[i]);

            return new { result = truncPrimes.Sum()};
        }
        
        private List<int> _tenPows = new List<int>() { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };

        private bool IsLeftTruncPrime(int n)
        {
            var digs = n.ToString().Select(c => int.Parse(c.ToString())).ToList();

            for(var i = digs.Count() - 1; i >= 0; i--)
                if (_calc.IsPrime(n))
                    n %= _tenPows[i];
                else
                    return false;


            return true;
        }

        private bool IsRightTruncPrime(int n)
        {
            while(n >= 1)            
                if (_calc.IsPrime(n))
                    n /= 10;
                else
                    return false;            
            return true;
        }
    }    
}
