using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_27 : Problem
    {
        //https://projecteuler.net/problem=27 Published on Friday, 27th September 2002, 05:00 pm; Solved by 74805;  Difficulty rating: 5% ---- completed
        //                                      
        // Euler discovered the remarkable quadratic formula:
        //
        // n^2+n+41
        // It turns out that the formula will produce 40 primes for the consecutive integer values 0≤n≤39. However, 
        // when n = 40, 40^2+40+41=40(40+1)+41 is divisible by 41, and certainly when n=41,41^2+41+41 is clearly divisible by 41.
        //
        // The incredible formula n^2−79n+1601 was discovered, which produces 80 primes for the consecutive values 0≤n≤79. 
        // The product of the coefficients, −79 and 1601, is −126479.
        //
        // Considering quadratics of the form:
        //
        // n^2+an+b, where |a|<1000 and |b|≤1000
        //
        // where |n| is the modulus/absolute value of n
        // e.g. |11|=11 and |−4|=4
        //
        //
        // Find the product of the coefficients, a and b, 
        // for the quadratic expression that produces the maximum number of primes for consecutive values of n,
        // starting with n = 0.

        // Notes:
        // 1.  b must be prime in order for n = 0 to be prime
        // 2.  the max n is b-1 since n = b => divisible by n
        // 3.   
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var primes = new List<int>(_calc.GetAllPrimes(max));

            var mostConsecutive = 0;
            var factorProduct = 0;

            for(var b = primes.Count() - 1; b >= 0; b--)
                for(var a = -1* primes[b] + 0; a <=primes[b]; a++)
                {
                    var i = 0;
                    while (_calc.IsPrime(i * i + a * i + primes[b]))
                        i++;
                    if(i > mostConsecutive)
                    {
                        mostConsecutive = i;
                        factorProduct = a * primes[b];
                    }
                }

            return new { result = factorProduct, most = mostConsecutive };
        }
        
        
    }    
}
