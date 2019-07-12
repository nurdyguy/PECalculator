using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Collections;

namespace ProblemService.Problems
{
    public class Problem_23 : Problem
    {
        //https://projecteuler.net/problem=23 Published on Friday, 2nd August 2002, 05:00 pm; Solved by 88905;  Difficulty rating: 5%  ---- completed
        //                                      
        // A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
        // For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
        // A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
        //
        // As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. 
        // By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
        // However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed 
        // as the sum of two abundant numbers is less than this limit.
        //
        // Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = 0;
            abundantBits = new BitArray(max);
            abundantNums = new List<int>();

            // 12 is first abundant
            for (var i = 12; i < max; i++)
                if (SumProperDivisors(i) > i)
                {
                    abundantBits[i] = true;
                    abundantNums.Add(i);
                }

            for(var i = 1; i < max; i++)
                if (!HasAbundantPairSum(i))
                    result += i;
            
            return new { result };
        }

        private BitArray abundantBits;
        private List<int> abundantNums;

        private bool HasAbundantPairSum(int num)
        {
            var found = false;
            for (var i = 0; i < abundantNums.Count() && abundantNums[i] < num; i++)
                if (abundantBits[num - abundantNums[i]])
                    return true;

            return found;
        }
        
        private int SumProperDivisors(int num)
        {
            if (num <= 1) return 0;

            var sum = 1;
            var sqrt = Math.Sqrt(num);
            for (var i = 2; i < sqrt; i++)
            {
                var div = num / i;
                if (i * div == num)
                    sum += i + div;
            }
            if (sqrt - (int)sqrt == 0)
                sum += (int)sqrt;
            return sum;
        }
    }    
}
