using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_25 : Problem
    {
        //https://projecteuler.net/problem=25 Published on Friday, 30th August 2002, 05:00 pm; Solved by 133836;  Difficulty rating: 5%--- completed
        //                                      
        // The Fibonacci sequence is defined by the recurrence relation:
        //
        // Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
        // Hence the first 12 terms will be:
        //
        // F1 = 1
        // F2 = 1
        // F3 = 2
        // F4 = 3
        // F5 = 5
        // F6 = 8
        // F7 = 13
        // F8 = 21
        // F9 = 34
        // F10 = 55
        // F11 = 89
        // F12 = 144
        // The 12th term, F12, is the first term to contain three digits.
        //   
        // What is the index of the first term in the Fibonacci sequence to contain 1000 digits?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var digits = (int)x;

            var fib1 = BigInteger.One;
            var fib2 = BigInteger.One;
            var fibNext = BigInteger.One;
            var index = new BigInteger(2);
            var max = BigInteger.Pow(10, digits - 1);

            while (fibNext < max)
            {
                fibNext = fib1 + fib2;
                index++;
                fib1 = fib2;
                fib2 = fibNext;
            }

            return new { result = index };
        }
        
        
    }    
}
