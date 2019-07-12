using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_39 : Problem
    {
        //https://projecteuler.net/problem=39 Published on Friday, 14th March 2003, 06:00 pm; Solved by 62747;        Difficulty rating: 5%
        //                                      
        // If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
        //
        // {20,48,52}, {24,45,51}, {30,40,50}
        //
        //For which value of p ≤ 1000, is the number of solutions maximised?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = 0;

            var maxPerim = 0;
            var maxCount = 0;

            var pythagTriples = new List<Tuple<int, int, int>>();

            for (var a = 1; a < max; a++)
                for (var b = a + 1; b < max; b++)
                {
                    var c = Math.Sqrt(a * a + b * b);
                    if (c - (int)c == 0)// && (int)_calc.lcm(new List<long>() { a, b, (int)c }) == a*b*c)
                        pythagTriples.Add(new Tuple<int, int, int>(a, b, (int)c));
                }

            var perims = new List<int>();
            for (var i = 0; i < pythagTriples.Count(); i++)
                perims.Add(pythagTriples[i].Item1 + pythagTriples[i].Item2 + pythagTriples[i].Item3);

            var counts = perims.Select(p => new Tuple<int, int>(p, perims.Count(p2 => p2 == p))).Where(c => c.Item1 <= max).ToList();
            for(var i = 0; i < counts.Count(); i++)
                if(counts[i].Item2 > maxCount)
                {
                    maxPerim = counts[i].Item1;
                    maxCount = counts[i].Item2;
                }


            return new { result = maxPerim };
        }
        
        
    }    
}
