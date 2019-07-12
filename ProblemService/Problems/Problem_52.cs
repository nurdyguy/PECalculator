using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_52 : Problem
    {
        //https://projecteuler.net/problem=52 Published on Friday, 12th September 2003, 05:00 pm; Solved by 57391;        Difficulty rating: 5%
        //                                      
        // It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
        //
        // Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var min = (int)y;
            var result = 0;

            for (var i = min; i <= max; i++)
                if (IsPermutation(i, 2 * i) && IsPermutation(i, 3 * i) && IsPermutation(i, 4 * i) && IsPermutation(i, 5 * i) && IsPermutation(i, 6 * i)) 
                    return new { result = i };

            return new { result };
        }
        
        private bool IsPermutation(int x, int y)
        {
            var xDigs = x.ToString().Select(c => int.Parse(c.ToString())).ToList();
            var yDigs = y.ToString().Select(c => int.Parse(c.ToString())).ToList();

            if (xDigs.Count() != yDigs.Count())
                return false;

            foreach(var d in xDigs)
                if (xDigs.Count(xd => xd == d) != yDigs.Count(yd => yd == d))
                    return false;

            return true;
        }
        
    }    
}
