using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_35 : Problem
    {
        //https://projecteuler.net/problem=35 Published on Friday, 17th January 2003, 06:00 pm; Solved by 73043; Difficulty rating: 5%
        //                                      
        // The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
        //
        // There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
        //
        // How many circular primes are there below one million?

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var circPrm = new List<int>() { 2, 5 };

            var primes = new List<int>(_calc.GetAllPrimes(max));

            _allPerms = new Dictionary<int, List<int[]>>();
            for (var i = 1; i <= 6; i++)
                _allPerms.Add(i, _calc.GenAllPermutations(i));

            _tenPows = new List<int>() { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };
            


            for (var i = 1; i < primes.Count(); i++)
                if (IsCircularPrime(primes[i]))
                    circPrm.Add(primes[i]);

            return new { result = circPrm.Count()};
        }
        
        private Dictionary<int, List<int[]>> _allPerms;
        private List<int> _tenPows;

        private bool IsCircularPrime(int p)
        {
            var digs = p.ToString().Select(c => int.Parse(c.ToString())).ToList();
            if (digs.Any(d => d == 5 || d % 2 == 0))
                return false;

            var testPrm = p;
            for(var i = 0; i < digs.Count(); i++)
            {
                if (!_calc.IsPrime(testPrm))
                    return false;
                testPrm = RotateDigits(testPrm);
            }

            return true;
        }

        private int RotateDigits(int n)
        {
            var digs = n.ToString().Select(c => int.Parse(c.ToString())).ToList();
            var rot = digs[0];
            for (var i = 1; i < digs.Count(); i++)
                rot += digs[i] * _tenPows[digs.Count() - i];
            return rot;
        }

    }    
}
