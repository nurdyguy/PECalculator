using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_40 : Problem
    {
        //https://projecteuler.net/problem=40 Published on Friday, 28th March 2003, 06:00 pm; Solved by 69069;   Difficulty rating: 5%
        //                                      
        // An irrational decimal fraction is created by concatenating the positive integers:
        //
        // 0.123456789101112131415161718192021...
        //
        // It can be seen that the 12th digit of the fractional part is 1.
        //
        // If dn represents the nth digit of the fractional part, find the value of the following expression.
        //
        // d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var str = "0";
            var n = 1;
            while(str.Length < max)
                str+= n++;

            var result = int.Parse(str[1].ToString()) * int.Parse(str[10].ToString()) * int.Parse(str[100].ToString())
                        * int.Parse(str[1000].ToString()) * int.Parse(str[10000].ToString()) * int.Parse(str[100000].ToString()) * int.Parse(str[1000000].ToString());

            return new { result };
        }
        
        
    }    
}
