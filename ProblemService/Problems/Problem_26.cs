using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_26 : Problem
    {
        //https://projecteuler.net/problem=26 Published on Friday, 13th September 2002, 05:00 pm; Solved by 71668;  Difficulty rating: 5%
        //                                      
        // A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
        //
        // 1/2	= 	0.5
        // 1/3	= 	0.(3)
        // 1/4	= 	0.25
        // 1/5	= 	0.2
        // 1/6	= 	0.1(6)
        // 1/7	= 	0.(142857)
        // 1/8	= 	0.125
        // 1/9	= 	0.(1)
        // 1/10	= 	0.1
        // Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle.It can be seen that 1/7 has a 6-digit recurring cycle.
        //
        // Find the value of d< 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var longest = 0;
            var longDenom = 0;
            for(var i = 11; i < max; i++)
            {
                var len = CountRepitionCycle(1, i);
                if(len > longest)
                {
                    longest = len;
                    longDenom = i;
                }
            }

            return new { result = longDenom };
        }
        
        private int CountRepitionCycle(int num, int denom)
        {
            var len = 0;
            var rems = new List<int>(denom);
            var done = false;

            var quot = 0;
            var curr = num;

            while(!done)
            {
                quot = curr / denom;
                var rem = curr - denom * quot;
                if (rem == 0)
                    break;

                if (rems.Contains(rem))
                    break;

                rems.Add(rem);
                curr = rem * 10;


            }



            return rems.Count();
        }
    }    
}
