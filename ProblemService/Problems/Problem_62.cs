using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_62 : Problem
    {
        //https://projecteuler.net/problem=62 Published on Friday, 30th January 2004, 06:00 pm; Solved by 26926;        Difficulty rating: 15%
        //                                      
        // The cube, 41063625 (345^3), can be permuted to produce two other cubes: 
        //          56623104 (384^3) and 66430125 (405^3). 
        // In fact, 41063625 is the smallest cube which has exactly three permutations of its digits which are also cube.
        //
        // Find the smallest cube for which exactly five permutations of its digits are cube.
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var matchGoal = (int)y;
            var cubes = new List<List<Cube>>() { new List<Cube>() };

            for(var i = 1; i <= max; i++)
            {
                var num = BigInteger.Pow(i, 3).ToString();
                var newCube = new Cube(i, num);

                for (var j = newCube.Value.Length - cubes.Count(); j >= 0; j--)
                    cubes.Add(new List<Cube>());
                
                cubes[newCube.Value.Length].Add(newCube);
            }
                
            foreach(var cubeFam in cubes)
            {
                foreach(var cube in cubeFam)
                {
                    var matches = new List<Cube>();
                    foreach (var otherCube in cubeFam)
                        if (Cube.CheckCubePermutationMatch(cube, otherCube))
                            matches.Add(otherCube);
                    if (matches.Count() == matchGoal)
                        return new { matches };
                }
            }
            


            return new { result = 0 };
        }
        
        private class Cube
        {
            public int Base { get; set; }
            public string Value { get; set; }
            public List<int> DigitCounts { get; set; }

            private Cube() { }
            public Cube(int b, string v)
            {
                Base = b;
                Value = v;
                DigitCounts = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (var i = 0; i < v.Length; i++)
                    DigitCounts[int.Parse(v[i].ToString())]++;
            }

            public static bool CheckCubePermutationMatch(Cube c1, Cube c2)
            {
                if (c1.Value.Length != c2.Value.Length)
                    return false;

                for (var i = 0; i < c1.DigitCounts.Count(); i++)
                    if (c1.DigitCounts[i] != c2.DigitCounts[i])
                        return false;
                return true;
            }
        }
        
    }    
}
