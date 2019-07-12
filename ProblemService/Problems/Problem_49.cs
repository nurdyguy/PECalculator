using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_49 : Problem
    {
        //https://projecteuler.net/problem=49 Published on Friday, 1st August 2003, 05:00 pm; Solved by 50550;        Difficulty rating: 5%
        //                                      
        // The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: 
        //  (i) each of the three terms are prime, and, 
        //  (ii) each of the 4-digit numbers are permutations of one another.
        //
        // There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.
        //
        // What 12-digit number do you form by concatenating the three terms in this sequence?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var pList = _calc.GetAllPrimes(10000).Where(p => p > 1487).ToList();
            var primePerms = new List<List<int>>();
            var result = new List<int>();

            while(pList.Any())
            {
                var minP = pList.First();
                var pDigs = minP.ToString().Select(c => int.Parse(c.ToString())).ToList();
                var digPerms = new List<int>();

                digPerms.Add(minP);
                pList.Remove(minP);

                for(var i = 1; i < 24; i++)
                {
                    var perms = _calc.GetPermutationFromCode(i, 4);
                    var n = pDigs[perms[0]] * 1000 +  pDigs[perms[1]] * 100 + pDigs[perms[2]] * 10 + pDigs[perms[3]];

                    if(pList.Contains(n))
                    {
                        digPerms.Add(n);
                        pList.Remove(n);
                    }

                }
                primePerms.Add(digPerms);
            }

            for(var i = 0; i < primePerms.Count(); i++)
                if (primePerms[i].Count() > 2)
                    for (var j = 0; j < primePerms[i].Count() - 2; j++)
                        for (var k = 1; j + k < primePerms[i].Count() - 1; k++)
                            if (primePerms[i].Contains(2 * primePerms[i][j + k] - primePerms[i][j]))
                                return new { result = $"{primePerms[i][j]}{primePerms[i][j + k]}{2 * primePerms[i][j + k] - primePerms[i][j]}" };

            return new { result = string.Join("", result) };
        }
    }    
}
