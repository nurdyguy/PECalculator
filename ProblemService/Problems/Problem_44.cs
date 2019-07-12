﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_44 : Problem
    {
        //https://projecteuler.net/problem=44 Published on Friday, 23rd May 2003, 05:00 pm; Solved by 49635;   Difficulty rating: 5%
        //                                      
        // Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2. The first ten pentagonal numbers are:
        //
        //      1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ...
        //
        // It can be seen that P4 + P7 = 22 + 70 = 92 = P8.However, their difference, 70 − 22 = 48, is not pentagonal.
        //
        // Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = | Pk − Pj | is minimised; what is the value of D?
        //
        // Notes:
        // 1. Consecutive difference increases by 3 each time
        // 2.  
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var diffs = new List<int>();
            
            var pents = new SortedList<int, int>();
            for(var i = 1; i <= max; i++)
            {
                var val = (3 * i * i - i) / 2;
                pents.Add(i, val);
            }
            var d = 0;
            var j = 1;
            while(d == 0)
            {
                for(var n = 1; n < pents.Count() - j; n++)
                {
                    var sum = pents[n + j] + pents[n];
                    var diff = pents[n + j] - pents[n];
                    if (pents.ContainsValue(sum) && pents.ContainsValue(diff))
                        d = diff;
                }
                j++;
            }
            


            return new { result = d };
        }
        
        
    }    
}
