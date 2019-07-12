using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_117 : Problem
    {
        //https://projecteuler.net/problem=117 Published on Friday, 10th March 2006, 06:00 pm; Solved by 9110; Difficulty rating: 35% ---------------
        //                                                      
        //
        // Using a combination of black square tiles and oblong tiles chosen from: red tiles measuring two units, 
        // green tiles measuring three units, and blue tiles measuring four units, it is possible to tile a row 
        // measuring five units in length in exactly fifteen different ways.
        //
        //  1 1 1 1 1
        //  2 1 1 1     1 2 1 1     1 1 2 1     1 1 1 2 
        //  2 2 1       2 1 2       1 2 2
        //  3 1 1       1 3 1       1 1 3       
        //  2 3         3 2            
        //  4 1         1 4
        //
        //
        // How many ways can a row measuring fifty units in length be tiled?
        //
        // NOTE: This is related to Problem 116.                                                                                                                                                                                                                   

        //-----------------------------------------------------------------------------------
        //Notes:
        // 1.  Find all linear combs if 1, 2, 3, 4 equalling max
        // 2.  use same formula from prob 116 on each comb
        // 3.  
        // 4.  


        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var result = BigInteger.Zero;

            //// pairs  --  tweak to use
            //for (var i = 1; i <= max / 2; i++)
            //{
            //    var count = _calc.PartialFactorial(max - i, max - 2 * i)/_calc.Factorial(i);
            //    result += count;
            //}

            var combs = FindLinearCombinations(max);

            combs.ForEach(c =>
            {
                result += _calc.Factorial(c.Item1 + c.Item2 + c.Item3 + c.Item4) / (_calc.Factorial(c.Item1) * _calc.Factorial(c.Item2) * _calc.Factorial(c.Item3) * _calc.Factorial(c.Item4));
            });



            return new { result };
        }
        
        private List<Tuple<int, int, int, int>> FindLinearCombinations(int max)
        {
            var combs = new List<Tuple<int, int, int, int>>();

            for (var _4s = 0; _4s <= max / 4; _4s++)
                for (var _3s = 0; _3s <= (max - 4 * _4s) / 3; _3s++)
                    for (var _2s = 0; _2s <= (max - 4 * _4s - 3 * _3s) / 2; _2s++)
                        combs.Add(new Tuple<int, int, int, int>(max - 4 * _4s - 3 * _3s - 2 * _2s, _2s, _3s, _4s));

            return combs;
        }
        
    }    
}
