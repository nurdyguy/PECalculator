using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_17 : Problem
    {
        //https://projecteuler.net/problem=17 Published on Friday, 17th May 2002, 05:00 pm; Solved by 129886; Difficulty rating: 5% --- completed
        //                                      
        //  If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
        //
        //If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
        //
        //
        //NOTE: Do not count spaces or hyphens.For example, 
        //    342 (three hundred and forty-two) contains 23 letters and 
        //    115 (one hundred and fifteen) contains 20 letters.
        //
        //The use of "and" when writing out numbers is in compliance with British usage.
        //
        // Notes:
        // Each of 1 - 99 happens 10 times, first as solo then with   x hundred and _____
        // 
        private string
            one = "one",
            two = "two",
            three = "three",
            four = "four",
            five = "five",
            six = "six",
            seven = "seven",
            eight = "eight",
            nine = "nine",
            ten = "ten",
            eleven = "eleven",
            twelve = "twelve",
            thirteen = "thirteen",
            fourteen = "fourteen",
            fifteen = "fifteen",
            sixteen = "sixteen",
            seventeen = "seventeen",
            eighteen = "eighteen",
            nineteen = "nineteen",
            // tens             
            twenty = "twenty",
            thirty = "thirty",
            forty = "forty",
            fifty = "fifty",
            sixty = "sixty",
            seventy = "seventy",
            eighty = "eighty",
            ninety = "ninety",
            and = "and",
            hundred = "hundred",
            thousand = "thousand";

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            
            // first 99----
            var first99 = 0;
            // single digits    -- 9 each
            first99 += one.Length * 9 + two.Length * 9 + three.Length * 9 + four.Length * 9 + five.Length * 9
                    + six.Length * 9 + seven.Length * 9 + eight.Length * 9 + nine.Length * 9;
            // teens            -- 1 each
            first99 += ten.Length + eleven.Length + twelve.Length + thirteen.Length + fourteen.Length
                    + fifteen.Length + sixteen.Length + seventeen.Length + eighteen.Length + nineteen.Length;
            // tens             -- 10 each
            first99 += twenty.Length * 10 + thirty.Length * 10 + forty.Length * 10 + fifty.Length * 10
                    + sixty.Length * 10 + seventy.Length * 10 + eighty.Length * 10 + ninety.Length * 10;

            // hundreds
            var oneHund = (one.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var twoHund = (two.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var threeHund = (three.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var fourHund = (four.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var fiveHund = (five.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var sixHund = (six.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var sevenHund = (seven.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var eightHund = (eight.Length + hundred.Length) * 100 + and.Length * 99 + first99;
            var nineHund = (nine.Length + hundred.Length) * 100 + and.Length * 99 + first99;

            var result = first99 + oneHund + twoHund + threeHund + fourHund + fiveHund
                        + sixHund + sevenHund + eightHund + nineHund + one.Length + thousand.Length;
            
            return new { result };
        }
        
        
    }    
}
