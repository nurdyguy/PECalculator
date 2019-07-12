using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_64 : Problem
    {
        //https://projecteuler.net/problem=64 PPublished on Friday, 27th February 2004, 06:00 pm; Solved by 18910;        Difficulty rating: 20%
        //                                      
        // All square roots are periodic when written as continued fractions and can be written in the form:
        //
        //  √N = a0 + 1/a1 + 1/a2 + 1/a3 + ...
        //  For example, let us consider √N: (see page for detail)
        //
        // 
        // The first ten continued fraction representations of (irrational) square roots are:
        //
        // √2 = [1; (2)],           period = 1
        // √3 = [1;(1,2)],          period = 2
        // √5 = [2;(4)],            period = 1
        // √6 = [2;(2,4)],          period = 2
        // √7 = [2;(1,1,1,4)],      period = 4
        // √8 = [2;(1,4)],          period = 2
        // √10 = [3;(6)],           period = 1
        // √11 = [3;(3,6)],         period = 2
        // √12 = [3;(2,6)],         period = 2
        // √13 = [3;(1,1,1,1,6)],   period = 5
        //
        //Exactly four continued fractions, for N ≤ 13, have an odd period.
        //
        //How many continued fractions for N ≤ 10000 have an odd period?
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var counter = 0;

            var sqrtDicts = new Dictionary<int, Tuple<List<int>,List<int>>>();

            for (var i = 0; i <= 10000; i++)
                _sqrts.Add(Math.Sqrt(i));

            for (var i = 2; i <= max; i++)
                sqrtDicts.Add(i, CalcContinuedFractionExpansion(i));

            return new { result = counter };
        }

        private List<double> _sqrts = new List<double>();
        private Tuple<List<int>, List<int>> CalcContinuedFractionExpansion(int root)
        {
            var nonRepNums = new List<int>();
            var repNums = new List<int>();
            var n = Math.Sqrt(root);

            var a_i = new List<int>() { (int)n };

            if (n == a_i[0])
                return new Tuple<List<int>, List<int>>(a_i, new List<int>());

            var done = false;
            var rem = -1 * a_i[0];
            while(!done)
            {
                var num = new List<int>() { 0, 1 };
                var denom = new List<int>() { root, rem };




                //var a = (int)(nextFrac.Item1 / (_sqrts[nextFrac.Item2] + nextFrac.Item3));
            }




            return null;

        }

        
    }    
}
