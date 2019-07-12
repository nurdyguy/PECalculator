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
    public class Problem_60 : Problem
    {
        //https://projecteuler.net/problem=60 Published on Friday, 2nd January 2004, 06:00 pm; Solved by 22549;        Difficulty rating: 20%
        //                                      
        // The primes 3, 7, 109, and 673, are quite remarkable. By taking any two primes and concatenating them in any order the result will always be prime. 
        // For example, taking 7 and 109, both 7109 and 1097 are prime. 
        // The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.
        //
        // Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var length = (int)y;
            var primes = _calc.GetAllPrimes(max).Where(p => p != 2 && p != 5);
            var pRem1 = primes.Where(p => p == 3 || p % 3 == 1).ToList();
            var pRem2 = primes.Where(p => p == 3 || p % 3 == 2).ToList();

            var combs = _calc.GenAllCombinations(length, 2);

            var best = new List<int>();
            var bestSum = length*max;
            var allFams_l2_mod1 = new List<List<int>>() {  };
            var allFams_l2_mod2 = new List<List<int>>() { };

            
            // 1 mod 3s
            for (var i = 1; i < _calc.nCr(pRem1.Count(), length); i++)
            {
                var primeIndexes = _calc.DecodeCombination(i, pRem1.Count(), length);
                var pList = new List<int>(primeIndexes.Count());
                for (var k = 0; k < primeIndexes.Count(); k++)
                    pList.Add(pRem1[primeIndexes[k]]);

                var failed = false;
                for (var k = 0; !failed && k < combs.Count(); k++)
                    if (!_calc.IsPrime(int.Parse($"{pList[combs[k][0]]}{pList[combs[k][1]]}")) || !_calc.IsPrime(int.Parse($"{pList[combs[k][1]]}{pList[combs[k][0]]}")))
                        failed = true;

                if (!failed)
                {
                    allFams_l2_mod1.Add(pList);
                }
            }

            // 2 mod 3s
            for (var i = 1; i < _calc.nCr(pRem2.Count(), length); i++)
            {
                var primeIndexes = _calc.DecodeCombination(i, pRem2.Count(), length);
                var pList = new List<int>(primeIndexes.Count());
                for (var k = 0; k < primeIndexes.Count(); k++)
                    pList.Add(pRem2[primeIndexes[k]]);

                var failed = false;
                for (var k = 0; !failed && k < combs.Count(); k++)
                    if (!_calc.IsPrime(int.Parse($"{pList[combs[k][0]]}{pList[combs[k][1]]}")) || !_calc.IsPrime(int.Parse($"{pList[combs[k][1]]}{pList[combs[k][0]]}")))
                        failed = true;

                if (!failed)
                {
                    allFams_l2_mod2.Add(pList);
                }
            }

            var _primes_m1 = _calc.GetAllPrimes(max * 10).Where(p => p % 3 == 1).ToList();
            var _primes_m2 = _calc.GetAllPrimes(max * 10).Where(p => p % 3 == 2).ToList();

            var allFams_l3_mod1 = new List<List<int>>();
            foreach (var fam in allFams_l2_mod1)
            {
                var next = FindNextFamilyPrime(fam, _primes_m1);
                if (next > 0)
                {
                    fam.Add(next);
                    allFams_l3_mod1.Add(fam);
                }
            }

            var allFams_l4_mod1 = new List<List<int>>();
            foreach (var fam in allFams_l3_mod1)
            {
                var next = FindNextFamilyPrime(fam, _primes_m1);
                if(next > 0)
                {
                    fam.Add(next);
                    allFams_l4_mod1.Add(fam);
                }
            }

            var allFams_l5_mod1 = new List<List<int>>();
            foreach (var fam in allFams_l4_mod1)
            {
                var next = FindNextFamilyPrime(fam, _primes_m1);
                if (next > 0)
                {
                    fam.Add(next);
                    allFams_l5_mod1.Add(fam);
                }
            }

            var allFams_l3_mod2 = new List<List<int>>();
            foreach (var fam in allFams_l2_mod2)
            {
                var next = FindNextFamilyPrime(fam, _primes_m2);
                if (next > 0)
                {
                    fam.Add(next);
                    allFams_l3_mod2.Add(fam);
                }
            }

            var allFams_l4_mod2 = new List<List<int>>();
            foreach (var fam in allFams_l3_mod2)
            {
                var next = FindNextFamilyPrime(fam, _primes_m2);
                if (next > 0)
                {
                    fam.Add(next);
                    allFams_l4_mod2.Add(fam);
                }
            }

            var allFams_l5_mod2 = new List<List<int>>();
            foreach (var fam in allFams_l4_mod2)
            {
                var next = FindNextFamilyPrime(fam, _primes_m2);
                if (next > 0)
                {
                    fam.Add(next);
                    allFams_l5_mod1.Add(fam);
                }
            }

            var result = new { fams_m1 = allFams_l5_mod1, fams_m1_sum = allFams_l5_mod1.Where(f => f.Count() == 5).Select(f => f.Sum()),
                fams_m2 = allFams_l5_mod2, fams_m2_sum = allFams_l5_mod2.Where(f => f.Count() == 5).Select(f => f.Sum()) };

            Debug.WriteLine("--------------------------------------------");
            //Debug.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(result));
            Debug.WriteLine("--------------------------------------------");
            return result;
        }
                
        private int FindNextFamilyPrime(List<int> primeFamily, List<int> primes)
        {
            foreach (var p in primes.Where(p => p > primeFamily.Last()))
            {
                var failed = false;
                for (var i = 0; !failed && i < primeFamily.Count(); i++)
                    if (!_calc.IsPrime(ulong.Parse($"{primeFamily[i]}{p}")) || !_calc.IsPrime(ulong.Parse($"{p}{primeFamily[i]}")))
                        failed = true;

                if (!failed)
                    return p;
            }
            return 0;
        }
    }    
}
