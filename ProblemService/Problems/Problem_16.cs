using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_16 : Problem
    {
        //https://projecteuler.net/problem=16 Published on Friday, 19th April 2002, 05:00 pm; Solved by 160026; Difficulty rating: 5% --- completed
        //                                      
        //  2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
        //
        //  What is the sum of the digits of the number 2^1000?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var exp = (int)x;
            var digitSum = 0;
            var twoPowStr = BigInteger.Pow(2, exp).ToString();
            for (var i = 0; i < twoPowStr.Length; i++)
                digitSum += int.Parse(twoPowStr[i].ToString());
            



            return new { result = digitSum };
        }
        
        
    }    
}
