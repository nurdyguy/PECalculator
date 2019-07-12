using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_51 : Problem
    {
        //https://projecteuler.net/problem=51 Published on Friday, 29th August 2003, 05:00 pm; Solved by 28803;        Difficulty rating: 15%
        //                                      
        // By replacing the 1st digit of the 2-digit number *3, it turns out that six of the nine possible values:
        //      13, 23, 43, 53, 73, and 83, are all prime.
        //
        // By replacing the 3rd and 4th digits of 56**3 with the same digit, this 5-digit number is the first example having seven primes among the ten generated numbers, 
        // yielding the family: 
        //      56003, 56113, 56333, 56443, 56663, 56773, and 56993. 
        // Consequently 56003, being the first member of this family, is the smallest prime with this property.
        //
        // Find the smallest prime which, by replacing part of the number (not necessarily adjacent digits) with the same digit, is part of an eight prime value family.

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var min = (int)y;
            var result = 0;

            var primes = _calc.GetAllPrimes(max).Where(p => p > min).ToList();

            var allCombs = new Dictionary<int, List<List<int>>>();

            for (var i = min.ToString().Length; i <= max.ToString().Length; i++)
                allCombs[i] = _calc.GenAllCombinations(i);

            foreach (var p in primes)
            {
                var digs = p.ToString().Select(c => int.Parse(c.ToString()));

                // num of digs being replaced
                for (var i = 1; i < digs.Count() - 1; i++)
                    foreach (var comb in allCombs[digs.Count()].Where(c => c.Count() == i))
                    {
                        var pFam = new List<List<int>>();
                        for (var j = comb[0] == 0 ? 1 : 0; j < 10; j++)
                        {
                            var num = digs.ToList();
                            
                            for (var k = 0;  k < comb.Count(); k++)
                                num[comb[k]] = j;

                            if (_calc.IsPrime(ConcatinateInts(num)))
                                pFam.Add(num);
                        }
                        if (pFam.Count() == 8)
                            return new { result = ConcatinateInts(pFam[0]) };
                    }
            }

            return new { result };
        }

        private int ConcatinateInts(IEnumerable<int> digits)
        {
            var result = 0;
            foreach (var d in digits)
                result = 10 * result + d;
            return result;
        }
        
        
    }    
}
