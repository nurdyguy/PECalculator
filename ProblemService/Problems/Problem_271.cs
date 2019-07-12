using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_271 : Problem
    {
        //https://projecteuler.net/problem=271 Published on Saturday, 2nd January 2010, 05:00 am; Solved by 1881;  Difficulty rating: 60%
        //
        // For a positive number n, define S(n) as the sum of the integers x, for which 1<x<n and
        // x^3≡1 mod n.

        // When n= 91, there are 8 possible values for x, namely : 9, 16, 22, 29, 53, 74, 79, 81.
        // Thus, S(91)= 9 + 16 + 22 + 29 + 53 + 74 + 79 + 81 = 363.

        // Find S(13,082,761,331,670,030).
        // 
        //-----------------------------------------------------------------------------------
        //Notes:
        // 1.  x^3 ends with a 1 so x ends with a 1
        // 2.  lower bound is 13082761331670030^(1/3) = 235631.3869...
        // 3.  
        // 4.   



        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = 13082761331670030.0;

            var result = BigInteger.Zero;

            var found = false;
            var mult = 1;
            for(var i = 1; i < max; i++)
            {
                var a = Math.Pow(i * max + 1, 1.0 / 3.0);
                if (a == (int)a && a%10 == 1)
                {

                    return new { result = a };
                }
                    
            }
            


            return new { result };
        }
        
        
    }    
}
