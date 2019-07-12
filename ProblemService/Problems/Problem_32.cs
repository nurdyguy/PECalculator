using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_32 : Problem
    {
        //https://projecteuler.net/problem=32 Published on Friday, 6th December 2002, 06:00 pm; Solved by 60858;  Difficulty rating: 5%
        //                                      
        // We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
        //
        // The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
        //
        // Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
        //
        // HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var prods = new List<int>();

            for(var m1 = 2; m1 < 100; m1++)
                for(var m2 = m1 + 1; m2 < 10000; m2++)
                {
                    var p = m1 * m2;
                    if (IsPandigitalProduct(m1, m2, p))
                        prods.Add(p);
                }

            prods = prods.Distinct().ToList();
            
            return new { result = prods.Sum() };
        }
        
        private bool IsPandigitalProduct(int m1, int m2, int p)
        {
            var passed = true;
            var digs = $"{m1}{m2}{p}".Select(c => int.Parse(c.ToString()));
            if (digs.Count() == 9)
            {
                for (var i = 1; i <= 9; i++)
                    if (digs.Count(d => d == i) != 1)
                        return false;
                return true;
            }                    
            return false;
        }
        
    }    
}
