using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_48 : Problem
    {
        //https://projecteuler.net/problem=48 Published on Friday, 18th July 2003, 05:00 pm; Solved by 100088;        Difficulty rating: 5%
        //                                      
        // The series, 11 + 22 + 33 + ... + 1010 = 10405071317.
        //
        // Find the last ten digits of the series, 11 + 22 + 33 + ... + 10001000.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = BigInteger.Zero;

            for (var i = 1; i <= max; i++)
                result += BigInteger.ModPow(i, i, 10000000000);

            return new { result = BigInteger.Remainder(result, 10000000000) };
        }
    }    
}
