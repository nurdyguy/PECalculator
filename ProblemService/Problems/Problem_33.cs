using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_33 : Problem
    {
        //https://projecteuler.net/problem=33 Published on Friday, 20th December 2002, 06:00 pm; Solved by 61550;    Difficulty rating: 5%
        //                                      
        // The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify 
        // it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
        //
        // We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
        //
        // There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
        //
        // If the product of these four fractions is given in its lowest common terms, find the value of the denominator.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var matches = new List<Tuple<int, int>>();
            
            for(var i = 10; i < 100; i++)
                for(var j = i+1; j < 100; j++)
                {
                    var numDigs = i.ToString().Select(c => int.Parse(c.ToString())).ToList();
                    var denomDigs = j.ToString().Select(c => int.Parse(c.ToString())).ToList();
                    if (numDigs[0] == denomDigs[1] && FractionsAreEqual(i, j, numDigs[1], denomDigs[0])
                            || numDigs[1] == denomDigs[0] && FractionsAreEqual(i, j, numDigs[0], denomDigs[1]))
                        matches.Add(new Tuple<int, int>(i, j));
                }

            var num = 1;
            var denom = 1;
            for(var i = 0; i < matches.Count(); i++)
            {
                num *= matches[i].Item1;
                denom *= matches[i].Item2;
            }

            var gcf = _calc.gcf(num, denom);

            return new { result = denom/gcf};
        }
        
        private bool FractionsAreEqual(int n1, int d1, int n2, int d2)
        {
            return n1 * d2 == d1 * n2;
        }
        
    }    
}
