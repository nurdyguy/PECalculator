﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_29 : Problem
    {
        //https://projecteuler.net/problem=29 Published on Friday, 25th October 2002, 05:00 pm; Solved by 90125; Difficulty rating: 5%
        //                                      
        // Consider all integer combinations of ab for 2 ≤ a ≤ 5 and 2 ≤ b ≤ 5:
        //
        //      2^2=4, 23^=8, 2^4=16, 2^5=32
        //      3^2=9, 3^3=27, 3^4=81, 3^5=243
        //      4^2=16, 4^3=64, 4^4=256, 4^5=1024
        //      5^2=25, 5^3=125, 5^4=625, 5^5=3125
        // If they are then placed in numerical order, with any repeats removed, we get the following sequence of 15 distinct terms:
        // 
        //      4, 8, 9, 16, 25, 27, 32, 64, 81, 125, 243, 256, 625, 1024, 3125
        // 
        // How many distinct terms are in the sequence generated by a^b for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var nums = new List<BigInteger>();

            for (var a = 2; a <= max; a++)
                for (var b = 2; b <= max; b++)
                    nums.Add(BigInteger.Pow(a, b));
            nums = nums.Distinct().ToList();

            return new { result = nums.Count()};
        }
        
        
    }    
}