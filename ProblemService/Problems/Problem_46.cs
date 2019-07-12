using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_46 : Problem
    {
        //https://projecteuler.net/problem=46 Published on Friday, 20th June 2003, 05:00 pm; Solved by 52519;        Difficulty rating: 5%
        //                                      
        // It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.
        //
        //  9  = 7  + 2×1^2
        //  15 = 7  + 2×2^2
        //  21 = 3  + 2×3^2
        //  25 = 7  + 2×3^2
        //  27 = 19 + 2×2^2
        //  33 = 31 + 2×1^2
        //
        // It turns out that the conjecture was false.
        //
        // What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = 0;

            for (var i = 1; i < 1000000; i++)
                _squares.Add(i * i);

            var n = 17;
            while(result == 0)
            {
                var odd = 2 * n + 1;
                var found = false;
                if (!_calc.IsPrime(odd))
                {
                    for (var i = 0; !found && i < _squares.Count() && 2 * _squares[i] < odd; i++)
                        if (_calc.IsPrime(odd - 2 * _squares[i]))
                            found = true;

                    if (!found)
                        return new { result = odd };
                }
                n++;
            }
                

            return new { result = 0 };
        }

        private List<long> _squares = new List<long>();
    }    
}
