using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_28 : Problem
    {
        //https://projecteuler.net/problem=28 Published on Friday, 11th October 2002, 05:00 pm; Solved by 94022; Difficulty rating: 5%
        //                                      
        // Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
        //
        //          21 22 23 24 25
        //          20  7  8  9 10
        //          19  6  1  2 11
        //          18  5  4  3 12
        //          17 16 15 14 13
        //
        // It can be verified that the sum of the numbers on the diagonals is 101.
        //
        // What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
        // Notes:
        // 1. 5x5 has 3 layers/rings, 1x1, 3x3, 5x5 --- so 1001x1001 has 501 layers/rings
        // 2. ring 2 each value increases by 2, ring 3 each value increases by 4, ring 4 each value increases by 6
        // 

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            // ring 1 included
            var sum = 1;
            var lastNum = 1;
            var ringIncr = 2;

            // starts on ring 2
            for(var i = 2; i <= (max+1)/2; i++)
            {

                for(var j = 0; j < 4; j++)
                {
                    lastNum += ringIncr;
                    sum += lastNum;
                }

                ringIncr += 2;
            }
            
            return new { result = sum };
        }
        
        
    }    
}
