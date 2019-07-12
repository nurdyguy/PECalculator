using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_63 : Problem
    {
        //https://projecteuler.net/problem=63 Published on Friday, 13th February 2004, 06:00 pm; Solved by 37568;        Difficulty rating: 5%
        //                                      
        // The 5-digit number, 16807=7^5, is also a fifth power.Similarly, the 9-digit number, 134217728=8^9, is a ninth power.
        //
        // How many n-digit positive integers exist which are also an nth power?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var matches = new List<BigInteger>();
            for(var i = 1; i <= max; i++)
                for(var j = 1; j <= max; j++)
                {
                    var num = BigInteger.Pow(i, j);
                    if (num.ToString().Length == j)
                        matches.Add(num);
                }
            return new { result = matches };
        }        
    }    
}
