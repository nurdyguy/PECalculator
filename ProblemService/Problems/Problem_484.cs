using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Numerics;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_484 : Problem
    {
        //Problem 483 --- https://projecteuler.net/problem=484 Published on Saturday, 11th October 2014, 12:00 pm; Solved by 182;   Difficulty rating: 100%
        //
        //The arithmetic derivative is defined by
        //
        //  p' = 1 for any prime p
        //  (ab)' = a'b + ab' for all integers a, b (Leibniz rule)
        // For example, 20' = 24
        //
        // Find ∑ gcd(k, k') for 1 < k ≤ 5·10^15
        //
        // Note: gcd(x, y) denotes the greatest common divisor of x and y.
        //
        // Notes:
        // 1. product rule (xyz)' = x'yz + xy'z + xyz'
        // 2. taken to prime factorization x=product(pi^ni), x' = sum(ni*pi^(ni-1)*pj^nj*pk*nk) j, k != i
        //    so each term has pi^(ni-1) common for all i
        //    so x' = product(pi^(ni-1)) * sum(ni*pj) j != i
        // 3. Ex:  600 = 2^3 * 3^1 * 5^2
        //    600' = 2^2 * 3^0 * 5^1 * (3 * 3^1 * 5^2 + 2^3 * 1 * 5^2 + 2^3 * 3^1 * 2)
        //         = 20 * (225 + 200 + 48) = 9460
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (long)x;
            var result = BigInteger.Zero;
            




            return result;
        }

        

    }
}
