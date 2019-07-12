using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_604 : Problem
    {
        //https://projecteuler.net/problem=604 Published on Sunday, 21st May 2017, 04:00 am; Solved by 387;  Difficulty rating: 40%
        //                                      
        //  Let F(N) be the maximum number of lattice points in an axis-aligned N×N square that the graph of a single strictly convex increasing function can pass through.
        //
        // You are given that F(1)=2, F(3)=3, F(9)=6, F(11)=7, F(100)=30 and F(50000)=1898.
        // Below is the graph of a function reaching the maximum 3 for N=3:
        // 
        // Find F(10^18).
        //
        // Notes:
        // n-1 + n*(n+1)/2 <= N  close to N as possible
        // 2n - 2 + n^2 + n = 2N
        // n^2 + 3n - 2 = 2N
        // n^2 + 3n - 2 - 2N = 0
        // n = (-3 +/- sqrt(9 - 4(-2-2N)))/2  --- ignore -
        // n = (-3 + sqrt(9 + 8 + 8N))/2
        // n = (-3 + sqrt(17 + 8N))/2
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var n = (Math.Sqrt(17 + 8 * max) - 3) / 2;

            n = (int)n;

            var height = n - 1 + (n * n + n) / 2;

            var latPts = 2 * n;

            return new { result = latPts };
        }
        
        
    }    
}
