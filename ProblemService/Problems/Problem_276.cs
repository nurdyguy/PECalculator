using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_276 : Problem
    {
        //https://projecteuler.net/problem=276 difficulty: 75%  
        //
        // Consider the triangles with integer sides a, b and c with a ≤ b ≤ c.
        // An integer sided triangle(a, b, c) is called primitive if gcd(a, b, c)=1. 
        // How many primitive integer sided triangles exist with a perimeter not exceeding 10 000 000?
        //                                                                                                                                                                                                                          
        //
        //-----------------------------------------------------------------------------------
        //Notes:
        // 1.  assume a < b < c so c > a + b
        // 2.  start with a = 1 and let b > a such that gcf(a, b) = 1
        // 3.  count c where c > a + b and gcf(a, b, c) = 1 and a + b + c <= 10,000,000
        // 4.  

        

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var aMax = max / 4;
            var bMax = max / 4;
            long count = 0;

            for(var a = 1; a < aMax; a++)
                for(var b = a + 1; b < bMax; b++)
                {
                    var cMin = a + b + 1;
                    var cMax = max - a - b;
                    for(var c = cMin; c <= cMax; c++)
                    {
                        count++;
                    }
                }



            return new { count };
        }
        
        
    }    
}
