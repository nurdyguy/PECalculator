using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_58 : Problem
    {
        //https://projecteuler.net/problem=58 Published on Friday, 5th December 2003, 06:00 pm; Solved by 34800;        Difficulty rating: 5%
        //                                      
        // Starting with 1 and spiralling anticlockwise in the following way, a square spiral with side length 7 is formed.
        //
        //          37 36 35 34 33 32 31
        //          38 17 16 15 14 13 30
        //          39 18  5  4  3 12 29
        //          40 19  6  1  2 11 28
        //          41 20  7  8  9 10 27
        //          42 21 22 23 24 25 26
        //          43 44 45 46 47 48 49
        //
        // It is interesting to note that the odd squares lie along the bottom right diagonal, but what is more interesting is that 8 out of the 13 
        // numbers lying along both diagonals are prime; that is, a ratio of 8/13 ≈ 62%.
        //
        // If one complete new layer is wrapped around the spiral above, a square spiral with side length 9 will be formed.If this process is continued, 
        // what is the side length of the square spiral for which the ratio of primes along both diagonals first falls below 10%?
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var diags = new List<int>() { 1, 3, 5, 7, 9, 13, 17, 21, 25, 31, 37, 43, 49 };
            var diagPrimes = new List<int>() { 3, 5, 7, 13, 17, 31, 37, 43 };

            var done = false;
            var plus = 8;
            while(!done)
            {
                for(var i = 0; i < 4; i++)
                {
                    var n = diags.Last() + plus;
                    diags.Add(n);
                    if (_calc.IsPrime(n))
                        diagPrimes.Add(n);
                }
                if (10 * diagPrimes.Count() < diags.Count())
                    return new { resuld = plus + 1 };
                plus += 2;
            }

            return new { result = 0 };
        }
                
    }    
}
