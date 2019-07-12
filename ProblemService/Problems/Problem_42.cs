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
    public class Problem_42 : Problem
    {
        //https://projecteuler.net/problem=42 Published on Friday, 25th April 2003, 05:00 pm; Solved by 64417;   Difficulty rating: 5%
        //                                      
        // The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
        //
        // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        //
        // By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value.For example, 
        //    the word value for SKY is 19 + 11 + 25 = 55 = t10.If the word value is a triangle number then we shall call the word a triangle word.
        //
        // Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = 0;
            var triNums = new List<int>() { 0, 1 };
            for(var i = 2; i <= 1000; i++)
            {
                triNums.Add(triNums[i - 1] + i);
            }
            for(var i = 0; i < Constants._e42_words.Count(); i++)
            {
                var wordVal = CalcWordValue(Constants._e42_words[i]);
                if (triNums.Any(n => n == wordVal))
                    count++;
            }

            return new { result = count };
        }

        private Dictionary<char, int> Letters = new Dictionary<char, int>()
        {
            { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 },{ 'E', 5 }, { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 },
            { 'J', 10 }, { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, { 'O', 15 }, { 'P', 16 }, { 'Q', 17 },
            { 'R', 18 }, { 'S', 19 }, { 'T', 20 }, { 'U', 21 }, { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 }, { 'Z', 26 }
        };

        private int CalcWordValue(string word)
        {
            var val = 0;
            for (var i = 0; i < word.Length; i++)
                val += Letters[word[i]];
            return val;
        }
        
    }    
}
