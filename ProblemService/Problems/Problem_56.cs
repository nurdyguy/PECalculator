using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_56 : Problem
    {
        //https://projecteuler.net/problem=56 Published on Friday, 7th November 2003, 06:00 pm; Solved by 51069;        Difficulty rating: 5%
        //                                      
        // A googol (10^100) is a massive number: one followed by one-hundred zeros; 100^100 is almost unimaginably large: one followed by two-hundred zeros. 
        // Despite their size, the sum of the digits in each number is only 1.
        //
        // Considering natural numbers of the form, a^b, where a, b< 100, what is the maximum digital sum?
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = 0;
            
            for(var i = 1; i < 100; i++)
                for(var j = 1; j < 100; j++)
                {
                    var num = BigInteger.Pow(i, j);
                    var sumDigs = num.ToString().Sum(c => int.Parse(c.ToString()));
                    if (sumDigs > max)
                        max = sumDigs;
                }

            return new { result = max };
        }
                
    }    
}
