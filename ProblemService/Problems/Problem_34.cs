using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_34 : Problem
    {
        //https://projecteuler.net/problem=34 Published on Friday, 3rd January 2003, 06:00 pm; Solved by 81020;   Difficulty rating: 5%
        //                                      
        // 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        //
        // Find the sum of all numbers which are equal to the sum of the factorial of their digits.
        //
        // Note: as 1! = 1 and 2! = 2 are not sums they are not included.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var matches = new List<int>();
            for (var i = 10; i <= max; i++)
                if (IsFactorialDigitMatch(i))
                    matches.Add(i);

            return new { result = matches};
        }
        
        private bool IsFactorialDigitMatch(int num)
        {
            var facts = new List<int> { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            var digs = num.ToString().Select(c => int.Parse(c.ToString())).ToList();
            var sum = 0;
            for (var i = 0; i < digs.Count(); i++)
                sum += facts[digs[i]];
            return num == sum;
        }
    }    
}
