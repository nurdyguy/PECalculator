using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_38 : Problem
    {
        //https://projecteuler.net/problem=38 Published on Friday, 28th February 2003, 06:00 pm; Solved by 53912;  Difficulty rating: 5%
        //                                      
        // Take the number 192 and multiply it by each of 1, 2, and 3:
        //
        //      192 × 1 = 192
        //      192 × 2 = 384
        //      192 × 3 = 576
        // By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and(1,2,3)
        //
        // The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and(1,2,3,4,5).
        //
        // What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with(1,2, ... , n) where n > 1?
        //
        // Notes:  
        // 1. number must start with 9
        // 2. since 9 is given, next number is 90 
        // 3. for 90 max n is 3
        // 4. for 900 max n is 2
        // 5. for 9000 max n is 2 --- pretty sure answer is here
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var result = 0;
            
            for (var i = 9123; i < 10000; i++)
            {
                var n = $"{i*1}{i*2}";
                if (Is1to9PanDigital(n) && int.Parse(n) > result)
                    result = int.Parse(n);
            }

            return new { result };
        }
        
        private bool Is1to9PanDigital(string str)
        {
            if (str.Length != 9 || str.Contains('0'))
                return false;

            var digs = str.Select(c => int.Parse(c.ToString()));
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
