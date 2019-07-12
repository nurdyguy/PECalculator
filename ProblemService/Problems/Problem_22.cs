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
    public class Problem_22 : Problem
    {
        //https://projecteuler.net/problem=15 Published on Friday, 19th July 2002, 05:00 pm; Solved by 115555;  Difficulty rating: 5%
        //                                      
        // Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
        // Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
        //
        // For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
        // So, COLIN would obtain a score of 938 × 53 = 49714.
        //
        // What is the total of all the name scores in the file?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var score = 0;
            var names = Constants._e22_names.OrderBy(n => n).ToList();
            for (var i = 0; i < names.Count(); i++)
                score += (i + 1) * CalcNameScore(names[i]);

            return new { result = score };
        }

        private Dictionary<char, int> alpha = new Dictionary<char, int>
        {
            { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 },
            { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 }, { 'J', 10 },
            { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, { 'O', 15 },
            { 'P', 16 }, { 'Q', 17 }, { 'R', 18 }, { 'S', 19 }, { 'T', 20 },
            { 'U', 21 }, { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 }, { 'Z', 26 }
        };
        private int CalcNameScore(string name)
        {
            var score = 0;
            for (var i = 0; i < name.Length; i++)
                score += alpha[name[i]];
            return score;
        }
    }    
}
