using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_20 : Problem
    {
        //https://projecteuler.net/problem= Published on Friday, 21st June 2002, 05:00 pm; Solved by 170995;   Difficulty rating: 5%--- completed
        //                                      
        // n! means n × (n − 1) × ... × 3 × 2 × 1
        //
        // For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
        // and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
        //
        // Find the sum of the digits in the number 100!

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var val = (int)x;
            var digitSum = 0;
            var fact = _calc.Factorial(val).ToString();
            for (var i = 0; i < fact.Length; i++)
                digitSum += int.Parse(fact[i].ToString());

            return new { result = digitSum };
        }
        
        
    }    
}
