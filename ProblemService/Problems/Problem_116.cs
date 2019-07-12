using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_116 : Problem
    {
        //https://projecteuler.net/problem=116 Published on Friday, 3rd March 2006, 06:00 pm; Solved by 9929; Difficulty rating: 30%difficulty: 25% ---------------
        //                                                      
        //
        // A row of five black square tiles is to have a number of its tiles replaced with coloured oblong tiles chosen from 
        // red(length two), green(length three), or blue(length four).
        //
        // If red tiles are chosen there are exactly seven ways this can be done.
        //
        //      2 1 1 1         1 2 1 1         1 1 2 1         1 1 1 2
        //      2 2 1           2 1 2           1 2 2
        //
        // If green tiles are chosen there are three ways.
        //
        //      3 1 1           1 3 1           1 1 3
        //
        // And if blue tiles are chosen there are two ways.
        //
        //      1 4             4 1
        //
        // Assuming that colours cannot be mixed there are 7 + 3 + 2 = 12 ways of replacing the black tiles in a row measuring five units in length.
        // How many different ways can the black tiles in a row measuring fifty units in length be replaced if colours cannot be mixed and at least one coloured tile must be used?
        //
        // NOTE: This is related to Problem 117.                                                                                                                                                                                                                   

        //-----------------------------------------------------------------------------------
        //Notes:
        // 1.  
        // 2.  
        // 3.  
        // 4.  

        
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = BigInteger.Zero;

            // pairs
            for (var i = 1; i <= max / 2; i++)
            {
                var count = _calc.PartialFactorial(max - i, max - 2 * i)/_calc.Factorial(i);
                result += count;
            }

            // trips
            for (var i = 1; i <= max / 3; i++)
            {
                var count = _calc.PartialFactorial(max - 2 * i, max - 3 * i) / _calc.Factorial(i);
                result += count;
            }


            // quads
            for (var i = 1; i <= max / 4; i++)
            {
                var count = _calc.PartialFactorial(max - 3 * i, max - 4 * i) / _calc.Factorial(i);
                result += count;
            }



            return new { result };
        }
        
        
    }    
}
