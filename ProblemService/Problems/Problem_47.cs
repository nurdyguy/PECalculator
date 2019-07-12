using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_47 : Problem
    {
        //https://projecteuler.net/problem=47 Published on Friday, 4th July 2003, 05:00 pm; Solved by 50515;        Difficulty rating: 5%
        //                                      
        //  The first two consecutive numbers to have two distinct prime factors are:
        //
        // 14 = 2 × 7
        // 15 = 3 × 5
        //
        // The first three consecutive numbers to have three distinct prime factors are:
        //
        // 644 = 2² × 7 × 23
        // 645 = 3 × 5 × 43
        // 646 = 2 × 17 × 19.
        //
        // Find the first four consecutive integers to have four distinct prime factors each.What is the first of these numbers?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = 0;

            var f = _calc.GetPrimeFactorization(50);

            for (var i = 100; i < max; i++)
                if (_calc.GetPrimeFactorization(i).Count() == 4 && _calc.GetPrimeFactorization(i + 1).Count() == 4
                    && _calc.GetPrimeFactorization(i + 2).Count() == 4 && _calc.GetPrimeFactorization(i + 3).Count() == 4)
                    return new { result = i };

            return new { result };
        }
        
        
    }    
}
