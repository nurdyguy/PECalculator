﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_12 : Problem
    {
        //https://projecteuler.net/problem=12 Published on Friday, 8th March 2002, 06:00 pm;  Difficulty rating: 5% ------------- completed
        //                                      
        //
        // The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
        //
        // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        //
        // Let us list the factors of the first seven triangle numbers:
        //
        //   1: 1
        //   3: 1,3
        //   6: 1,2,3,6
        //  10: 1,2,5,10
        //  15: 1,3,5,15
        //  21: 1,3,7,21
        //  28: 1,2,4,7,14,28
        //
        // We can see that 28 is the first triangle number to have over five divisors.
        //
        // What is the value of the first triangle number to have over five hundred divisors?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var minFactors = (int)x;
            var num = 0;

            for(var i = 1; i < int.MaxValue; i++)
            {
                num += i;
                var factors = CountFactors(num);
                if (factors > minFactors)
                    return new { result = num };
            }


            return new { result = false };
        }
        
        public int CountFactors(int num)
        {
            var count = 1;
            var factorization = _calc.GetPrimeFactorization(num);
            var vals = factorization.Values.ToArray();

            for (var i = 0; i < vals.Length; i++)
                count *= vals[i] + 1;

            return count;
        }
    }    
}
