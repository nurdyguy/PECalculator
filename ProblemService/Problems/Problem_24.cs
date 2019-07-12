using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_24 : Problem
    {
        //https://projecteuler.net/problem=24 Published on Friday, 16th August 2002, 05:00 pm; Solved by 98778; Difficulty rating: 5% --- completed
        //                                      
        // A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
        // If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. 
        // The lexicographic permutations of 0, 1 and 2 are:
        //
        //      012   021   102   120   201   210
        //
        // What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var code = (int)x;
            var length = (int)y;
            var perLength = (int)y;

            var result = _calc.GetPermutationFromCode(code, length);

            return new { result };
        }
        
        
    }    
}
