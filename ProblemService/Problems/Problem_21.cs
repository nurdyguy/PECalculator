using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_21 : Problem
    {
        //https://projecteuler.net/problem=21 Published on Friday, 5th July 2002, 05:00 pm; Solved by 125257;  Difficulty rating: 5%
        //                                      
        // Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
        // If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
        //
        // For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
        //   therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
        //
        // Evaluate the sum of all the amicable numbers under 10000.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = 0;

            var amics = new List<int>();
            for (var i = 2; i < max; i++)
            {
                var spd = SumProperDivisors(i);
                if (spd != i && SumProperDivisors(spd) == i)
                { 
                    amics.Add(i);
                    amics.Add(spd);
                }
            }
            result = amics.Distinct().Sum();

            return new { result };
        }
        
        private int SumProperDivisors(int num)
        {
            if (num <= 1) return 0;

            var sum = 1;
            var sqrt = Math.Sqrt(num);
            for(var i = 2; i < sqrt; i++)
            {
                var div = num / i;
                if(i*div == num)                
                    sum += i + div;                
            }
            if (sqrt - (int)sqrt == 0)
                sum += (int)sqrt;
            return sum;
        }
        
    }    
}
