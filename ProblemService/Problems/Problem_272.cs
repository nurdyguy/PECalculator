using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_272 : Problem
    {
        //https://projecteuler.net/problem=272 Published on Saturday, 2nd January 2010, 05:00 am; Solved by 726; Difficulty rating: 80%
        //
        // For a positive number n, define C(n) as the number of the integers x, for which 1<x<n and
        // x^3≡1 mod n.
        //
        // When n= 91, there are 8 possible values for x, namely : 9, 16, 22, 29, 53, 74, 79, 81.
        // Thus, C(91)=8.
        //
        // Find the sum of the positive numbers n ≤ 10^11 for which C(n)=242.
        // 
        //-----------------------------------------------------------------------------------
        //Notes:
        // 1.  
        // 2.  
        // 3.  
        // 4.  



        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = (long)0;
            


            return new { count };
        }
        
        
    }    
}
