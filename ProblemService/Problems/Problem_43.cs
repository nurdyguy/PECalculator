using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;
using ProblemService.Models;

namespace ProblemService.Problems
{
    public class Problem_43 : Problem
    {
        //https://projecteuler.net/problem=43 Published on Friday, 9th May 2003, 05:00 pm; Solved by 51040;  Difficulty rating: 5%
        //                                      
        // The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, 
        // but it also has a rather interesting sub-string divisibility property.
        //
        // Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:
        //
        //
        //      d2d3d4  = 406 is divisible by 2
        //      d3d4d5  = 063 is divisible by 3
        //      d4d5d6  = 635 is divisible by 5
        //      d5d6d7  = 357 is divisible by 7
        //      d6d7d8  = 572 is divisible by 11
        //      d7d8d9  = 728 is divisible by 13
        //      d8d9d10 = 289 is divisible by 17
        //
        // Find the sum of all 0 to 9 pandigital numbers with this property.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var size = (int)x;
            var max = _calc.Factorial(size);
            var nums = new List<long>();

            var i = -1;
            //long i = 362879;
            while(i < max - 1)
            {
                i++;

                var digs = _calc.GetPermutationFromCode(i, size);

                if (digs[0] == 0)
                    continue;

                //if (!IsPandigital(i))
                //    continue;

                if (digs[3] % 2 != 0)
                    continue;
                if ((digs[2] + digs[3] + digs[4]) % 3 != 0)
                    continue;
                if (digs[5] != 0 && digs[5] != 5)
                    continue;
                if ((digs[4] * 100 + digs[5] * 10 + digs[6]) % 7 != 0)
                    continue;
                if ((digs[5] * 100 + digs[6] * 10 + digs[7]) % 11 != 0)
                    continue;
                if ((digs[6] * 100 + digs[7] * 10 + digs[8]) % 13 != 0)
                    continue;
                if ((digs[7] * 100 + digs[8] * 10 + digs[9]) % 17 != 0)
                    continue;

                var num = (long)0;
                var tenPows = new List<long>() { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000 };
                for (var j = digs.Length - 1; j >= 0; j--)
                    num += digs[j] * tenPows[digs.Length - j - 1];

                nums.Add(num);
            }

            var result = nums.Sum();
            return new { result };
        }

        private bool IsPandigital(long n)
        {
            var str = n.ToString();
            var digsUsed = new int[str.Length + 1];

            for (var i = 0; i < str.Length; i++)
            {
                var dig = int.Parse(str[i].ToString());
                
                if (digsUsed[dig] == 0)
                    digsUsed[dig]++;
                else
                    return false;
            }

            return true;
        }

    }    
}
