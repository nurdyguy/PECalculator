using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_19 : Problem
    {
        //https://projecteuler.net/problem=19 Published on Friday, 14th June 2002, 05:00 pm; Solved by 116004; Difficulty rating: 5%
        //                                      
        //  You are given the following information, but you may prefer to do some research for yourself.

        // 1 Jan 1900 was a Monday.
        //
        // Thirty days has September, April, June and November.
        // 
        // All the rest have thirty-one,
        //
        // Saving February alone, Which has twenty-eight, rain or shine.
        // 
        // And on leap years, twenty-nine.
        // 
        // A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        //
        // How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = 0;

            for (var year = 1901; year <= 2000; year++)
                for (var m = 1; m <= 12; m++)
                    if (new DateTime(year, m, 1).DayOfWeek == DayOfWeek.Sunday)
                        result++;
            
            return new { result };
        }
        
        
    }    
}
