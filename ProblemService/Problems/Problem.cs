using System;
using System.Collections.Generic;
using System.Text;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public abstract class Problem 
    {

        public abstract object RunProblem(double x, double y = 0, double z = 0);
        
    }
}
