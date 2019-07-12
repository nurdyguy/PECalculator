using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_41 : Problem
    {
        //https://projecteuler.net/problem=41 PPublished on Friday, 11th April 2003, 05:00 pm; Solved by 58485;   Difficulty rating: 5%
        //                                      
        // We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
        //
        // What is the largest n-digit pandigital prime that exists?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;


            var primes = _calc.GetAllPrimes(10000000);

            for (var i = primes.Count() - 1; i > 0; i--)
                if (IsPandigital(primes[i]))
                    return new { result = primes[i] };

            return new { result = 1 };
        }
        
        private bool IsPandigital(int n)
        {
            var str = n.ToString();
            var digsUsed = new int[str.Length+1];

            for (var i = 0; i < str.Length; i++)
            {
                var dig = int.Parse(str[i].ToString());
                if (dig == 0 || dig > str.Length)
                    return false;
                if (digsUsed[dig] == 0)
                    digsUsed[dig]++;
                else
                    return false;
            }

            return true;            
        }
        
    }    
}
