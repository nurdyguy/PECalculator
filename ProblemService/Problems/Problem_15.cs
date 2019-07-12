using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_15 : Problem
    {
        //https://projecteuler.net/problem=15 Published on Friday, 19th April 2002, 05:00 pm; Solved by 160026; Difficulty rating: 5% --- completed
        //                                      
        // Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        //
        // How many such routes are there through a 20×20 grid?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var result = _calc.nCr(2*max, max);
            
            return new { result };
        }
        
        
    }    
}
