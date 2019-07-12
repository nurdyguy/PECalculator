using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_14 : Problem
    {
        //https://projecteuler.net/problem=14 Published on Friday, 5th April 2002, 05:00 pm; Solved by 193634; Difficulty rating: 5%
        //                                      
        //  The following iterative sequence is defined for the set of positive integers:
        //
        // n → n/2 (n is even)
        // n → 3n + 1 (n is odd)

        // Using the rule above and starting with 13, we generate the following sequence:

        // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        // Which starting number, under one million, produces the longest chain?

        // NOTE: Once the chain starts the terms are allowed to go above one million.

        
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var startNum = 0;
            var chainLength = 0;

            var a = calc3np1Length(837799);
            for (var i = 1; i <= max; i++)
            {
                var nextChain = calc3np1Length(i);
                if (nextChain > chainLength)
                {
                    chainLength = nextChain;
                    startNum = i;
                }
            }
            
            return new { result = startNum };
        }
        
        private int calc3np1Length(long num)
        {
            var length = 1;
            while (num > 1)
            {
                length++;
                if (num % 2 == 0)
                    num = num / 2;
                else
                    num = 3 * num + 1;
            }
            return length;
        }
        
    }    
}
