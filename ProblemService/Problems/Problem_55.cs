using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_55 : Problem
    {
        //https://projecteuler.net/problem=55 Published on Friday, 24th October 2003, 05:00 pm; Solved by 47101;        Difficulty rating: 5%
        //                                      
        // If we take 47, reverse and add, 47 + 74 = 121, which is palindromic.
        //
        // Not all numbers produce palindromes so quickly.For example,
        //
        // 349 + 943 = 1292,
        // 1292 + 2921 = 4213
        // 4213 + 3124 = 7337
        //
        // That is, 349 took three iterations to arrive at a palindrome.
        //
        // Although no one has proved it yet, it is thought that some numbers, like 196, never produce a palindrome. 
        // A number that never forms a palindrome through the reverse and add process is called a Lychrel number. 
        // Due to the theoretical nature of these numbers, and for the purpose of this problem, we shall assume that a number is Lychrel until proven otherwise. 
        // In addition you are given that for every number below ten-thousand, it will either 
        //      (i) become a palindrome in less than fifty iterations, or, 
        //      (ii) no one, with all the computing power that exists, has managed so far to map it to a palindrome. 
        // In fact, 10677 is the first number to be shown to require over fifty iterations before producing a palindrome: 4668731596684224866951378664 (53 iterations, 28-digits).
        //
        // Surprisingly, there are palindromic numbers that are themselves Lychrel numbers; the first example is 4994.
        //
        // How many Lychrel numbers are there below ten-thousand?
        //
        // NOTE: Wording was modified slightly on 24 April 2007 to emphasise the theoretical nature of Lychrel numbers.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var min = (int)y;
            var result = 0;
            var lychrels = new List<int>();

            for (var i = min; i <= max; i++)
            {
                BigInteger num = i;
                var isLych = true;
                for (var j = 0; isLych && j < 50; j++)
                {
                    num = ReverseSum(num);
                    if (IsPalindrome(num))
                        isLych = false;
                }
                if (isLych)
                    lychrels.Add(i);
            }

            return new { result = lychrels.Count() };
        }
        
        private BigInteger ReverseSum(BigInteger num)
        {
            return num + BigInteger.Parse(string.Join("", num.ToString().Select(c => c).Reverse()));
        }

        private bool IsPalindrome(BigInteger num)
        {
            var digs = num.ToString();
            for (var i = 0; i < digs.Count() / 2; i++)
                if (digs[i] != digs[digs.Count() - i - 1])
                    return false;
            return true;
        }
        
    }    
}
