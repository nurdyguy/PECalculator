using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_57 : Problem
    {
        //https://projecteuler.net/problem=57 Published on Friday, 21st November 2003, 06:00 pm; Solved by 35939;        Difficulty rating: 5%
        //                                      
        // It is possible to show that the square root of two can be expressed as an infinite continued fraction.
        //
        //  √ 2 = 1 + 1/(2 + 1/(2 + 1/(2 + ... ))) = 1.414213...
        //
        // By expanding this for the first four iterations, we get:
        //
        // 1 + 1/2 = 3/2 = 1.5
        // 1 + 1/(2 + 1/2) = 7/5 = 1.4
        // 1 + 1/(2 + 1/(2 + 1/2)) = 17/12 = 1.41666...
        // 1 + 1/(2 + 1/(2 + 1/(2 + 1/2))) = 41/29 = 1.41379...
        //
        // The next three expansions are 99/70, 239/169, and 577/408, but the eighth expansion, 1393/985, 
        // is the first example where the number of digits in the numerator exceeds the number of digits in the denominator.
        //
        // In the first one-thousand expansions, how many fractions contain a numerator with more digits than denominator?
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var counter = 0;

            var fracs = new List<List<BigInteger>>() { new List<BigInteger>() { 3, 2 }, new List<BigInteger> { 7, 5 } };

            for (var i = 3; i <= 1000; i++)
            {
                fracs.Add(new List<BigInteger>() { 2 * fracs[i - 2][0] + fracs[i - 3][0], 2 * fracs[i - 2][1] + fracs[i - 3][1] });
                if (fracs[i - 1][0].ToString().Count() > fracs[i - 1][1].ToString().Count())
                    counter++;
            }

            return new { result = counter };
        }
                
    }    
}
