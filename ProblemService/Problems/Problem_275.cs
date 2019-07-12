using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_275 : Problem
    {
        //https://projecteuler.net/problem=275 Published on Friday, 22nd January 2010, 05:00 pm; Solved by 485; Difficulty rating: 85%
        //     image:  https://projecteuler.net/project/images/p275_sculptures2.gif                                 
        //
        // Let us define a balanced sculpture of order n as follows:

        //      1.  A polyomino made up of n+1 tiles known as the blocks(n tiles) and the plinth(remaining tile);
        //      2.  the plinth has its centre at position(x= 0, y= 0);
        //      3.  the blocks have y-coordinates greater than zero(so the plinth is the unique lowest tile);
        //      4.  the centre of mass of all the blocks, combined, has x-coordinate equal to zero.
        //
        // When counting the sculptures, any arrangements which are simply reflections about the y-axis, are not counted as distinct.
        // For example, the 18 balanced sculptures of order 6 are shown below; note that each pair of mirror images(about the y-axis) is counted as one sculpture:
        //
        //
        // There are 964 balanced sculptures of order 10 and 360505 of order 15.
        // How many balanced sculptures are there of order 18?
        //
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = 0;


            return new { result = count };
        }
        
        
    }    
}
