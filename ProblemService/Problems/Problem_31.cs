using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_31 : Problem
    {
        //https://projecteuler.net/problem=31 Published on Friday, 22nd November 2002, 06:00 pm; Solved by 72505;  Difficulty rating: 5%
        //                                      
        // In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
        //
        //      1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
        // It is possible to make £2 in the following way:
        //
        //      1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
        // How many different ways can £2 be made using any number of coins?
        // this is a gross solution...
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = 0;

            var vals = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
            var maxs = new List<int> { 200, 100, 40, 20, 10, 4, 2, 1 };

            for (var a = 0; a <= maxs[0]; a++)
                for (var b = 0; b <= maxs[1]; b++)
                    for (var c = 0; c <= maxs[2]; c++)
                        for (var d = 0; d <= maxs[3]; d++)
                            for (var e = 0; e <= maxs[4]; e++)
                                for (var f = 0; f <= maxs[5]; f++)
                                    for (var g = 0; g <= maxs[6]; g++)
                                        for(var h = 0; h <= maxs[7]; h++)
                                            if (a * vals[0] + b * vals[1] + c * vals[2] + d * vals[3] + e * vals[4] + f * vals[5] + g * vals[6] + h * vals[7] == 200)
                                                count++;

            return new { result = count };
        }
        
        
    }    
}
