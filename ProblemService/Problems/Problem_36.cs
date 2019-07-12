using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_36 : Problem
    {
        //https://projecteuler.net/problem=36 Published on Friday, 31st January 2003, 06:00 pm; Solved by 76940;  Difficulty rating: 5%
        //                                      
        // The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
        //
        // Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        //
        // (Please note that the palindromic number, in either base, may not include leading zeros.)

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var doubPals = new List<int>();
            var binFails = new List<string>();
            for(var i = 1; i < max; i++)
            {
                if(IsPalindrome(i.ToString()))
                {
                    var bin = ToBinaryString(i);
                    if (IsPalindrome(bin))
                        doubPals.Add(i);
                }
            }


            return new { result = doubPals.Sum() };
        }

        private List<BigInteger> _tenPows = new List<BigInteger>() { 1,
                                BigInteger.Pow(10, 1), BigInteger.Pow(10, 2), BigInteger.Pow(10, 3), BigInteger.Pow(10, 4), BigInteger.Pow(10, 5),
                                BigInteger.Pow(10, 6), BigInteger.Pow(10, 7), BigInteger.Pow(10, 8), BigInteger.Pow(10, 9), BigInteger.Pow(10, 10),
                                BigInteger.Pow(10, 11), BigInteger.Pow(10, 12), BigInteger.Pow(10, 13), BigInteger.Pow(10, 14), BigInteger.Pow(10, 15),
                                BigInteger.Pow(10, 16), BigInteger.Pow(10, 17), BigInteger.Pow(10, 18), BigInteger.Pow(10, 19), BigInteger.Pow(10, 20),
                                BigInteger.Pow(10, 21), BigInteger.Pow(10, 22), BigInteger.Pow(10, 23), BigInteger.Pow(10, 24), BigInteger.Pow(10, 25) };

        private bool IsPalindrome(string str)
        {
            for (var i = 0; i < str.Count() / 2; i++)
                if (str[i] != str[str.Count() - 1 - i])
                    return false;
            return true;
        }

        private string ToBinaryString(int n)
        {
            var bin = BigInteger.Zero;
            for(var i = 0; n > 0; i++)
            {
                bin += (n % 2) * _tenPows[i];
                n /= 2;
            }
            return bin.ToString();
        }
    }    
}
