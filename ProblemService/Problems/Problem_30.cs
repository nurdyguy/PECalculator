using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_30 : Problem
    {
        //https://projecteuler.net/problem=30 Published on Friday, 8th November 2002, 06:00 pm; Solved by 94374;  Difficulty rating: 5%
        //                                      
        // Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
        //
        //      1634 = 1^4 + 6^4 + 3^4 + 4^4
        //      8208 = 8^4 + 2^4 + 0^4 + 8^4
        //      9474 = 9^4 + 4^4 + 7^4 + 4^4
        //
        // As 1 = 14 is not a sum it is not included.
        //
        // The sum of these numbers is 1634 + 8208 + 9474 = 19316.
        //
        // Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
        //
        // Notes:
        // 9^5 = 59049 so if we have 999999 then 9^5 * 6 has 6 digits --- theoretically possible for 6 digit nums at max
        // theoretical min is 2 digs
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var exp = (int)x;
            var matches = new List<int>();
            for(var i = 10; i < 1000000; i++)
            {
                var numDigs = i.ToString();
                var numSum = 0;
                for (var j = 0; j < numDigs.Length; j++)
                    numSum += (int)Math.Pow(int.Parse(numDigs[j].ToString()), exp);
                if (i == numSum)
                    matches.Add(i);
            }
            
            
            return new { result = matches };
        }
        
        
    }    
}
