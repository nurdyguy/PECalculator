using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_415 : Problem
    {
        //https://projecteuler.net/problem=415 Published on Sunday, 17th February 2013, 10:00 am; Solved by 227; Difficulty rating: 100%------------- incomplete
        //                                      
        //
        // A set of lattice points S is called a titanic set if there exists a line passing through exactly two points in S.
        //
        // An example of a titanic set is S = {(0, 0), (0, 1), (0, 2), (1, 1), (2, 0), (1, 0)}, 
        // where the line passing through(0, 1) and(2, 0) does not pass through any other point in S.
        //
        // On the other hand, the set {(0, 0), (1, 1), (2, 2), (4, 4)} is not a titanic set since the line 
        // passing through any two points in the set also passes through the other two.
        //
        // For any positive integer N, let T(N) be the number of titanic sets S whose every point (x, y) 
        // satisfies 0 ≤ x, y ≤ N.It can be verified that T(1) = 11, T(2) = 494, T(4) = 33554178, T(111) mod 10^8 = 13500401 and T(10^5) mod 10^8 = 63259062.
        //
        // Find T(10^11) mod 10^8.
        //
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = 0;

            return new { result = count };
        }

        
        
    }    
}
