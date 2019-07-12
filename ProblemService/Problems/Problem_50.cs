using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_50 : Problem
    {
        //https://projecteuler.net/problem=49 Published on Friday, 15th August 2003, 05:00 pm; Solved by 54451;        Difficulty rating: 5%
        //                                      
        // The prime 41, can be written as the sum of six consecutive primes:
        //
        // 41 = 2 + 3 + 5 + 7 + 11 + 13
        // This is the longest sum of consecutive primes that adds to a prime below one-hundred.
        //
        // The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
        //
        // Which prime, below one-million, can be written as the sum of the most consecutive primes?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            
            var p = _calc.GetAllPrimes(max).ToList();

            var longest = 0;
            var longestStart = 0;

            for(var i = 0; i < p.Count(); i++)
            {
                for(var j = 0; j < i; j++)
                {
                    var sum = 0;
                    for (var k = j; k < i && sum < p[i]; k++)
                    {
                        sum += p[k];

                        if(sum == p[i] && k - j + 1 > longest)
                        {
                            longest = k - j + 1;
                            longestStart = p[j];
                            Debug.WriteLine($"-----Prime {p[i]} is the sum of {k - j + 1} primes starting with {p[j]}.-----");
                        }
                    }

                }
            }

            return new { longest = longest, start = longestStart };
        }
    }    
}
