using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_184 : Problem
    {
        //https://projecteuler.net/problem=184 Published on Friday, 29th February 2008, 09:00 pm; Solved by 1259; Difficulty rating: 75% ---------completed
        //
        // Consider the set I_r of points (x,y) with integer co-ordinates in the interior of the circle with radius r, centered at the origin, i.e. x^2 + y^2 < r^2.
        //
        // For a radius of 2, I_2 contains the nine points(0,0), (1,0), (1,1), (0,1), (-1,1), (-1,0), (-1,-1), (0,-1) and(1,-1). 
        // There are eight triangles having all three vertices in I2 which contain the origin in the interior.Two of them are shown below,
        // the others are obtained from these by rotation.
        //
        //
        // For a radius of 3, there are 360 triangles containing the origin in the interior and having all vertices in I_3 and for I_5 the number is 10600.
        //
        // How many triangles are there containing the origin in the interior and having all three vertices in I105?

        //-----------------------------------------------------------------------------------
        //Notes:
        // 1.  Find all points inside I_r
        // 2.  Find all line pairs in Q1 U Q2
        // 3.  
        // 4.  


        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var radius = (int)x;
            var count = (long)0;
            
            var points = GetLatticeInsideCircle(radius);
            points = points.Where(p => p.X * p.X + p.Y * p.Y != 0).ToList();

            // partition by slope approx
            var lines = new SortedDictionary<double, List<Line>>();
            for (var i = 0; i < points.Count; i++)
            {
                var newLine = new Line(points[i].X, points[i].Y);
                if (lines.Keys.Contains(newLine.Approximate))
                    lines[newLine.Approximate].Add(newLine);
                else
                    lines.Add(newLine.Approximate, new List<Line>() { newLine });
            }
            
            var keys = lines.Keys.ToArray();
            for (var i = 0; i < keys.Length ; i++)
            {
                long roundCount = 0;

                for(var j = i + 2; j < keys.Length; j++)
                    roundCount += lines[keys[j - 1]].Count * lines[keys[i]].Count/2 * lines[keys[j]].Count/2;

                count += roundCount;
            }

            return new { count };
        }

        

        private List<Point> GetLatticeInsideCircle(int radius)
        {
            var points = new List<Point>();
            var r2 = radius * radius;
            for (var x = -1 * radius + 1; x <= radius - 1; x++)
                for (var y = -1 * radius + 1; y <= radius - 1; y++)
                    if(x*x + y*y < r2)
                        points.Add(new Point() { X = x, Y = y });

            return points;
        }



        private class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        private class Line 
        {
            private int _rise;
            private int _run;
            private double _approx;

            public int Rise { get { return _rise; } }
            public int Run { get { return _run; } }
            public double Approximate { get { return _approx; } }

            public Line(int x, int y)
            {
                this._rise = y;
                this._run = x;

                if (_run == 0)
                    //if (y > 0)
                        this._approx = 9999999999;
                    //else
                    //    this._approx = -9999999999;
                else
                    this._approx = (double)y / x;
            }

        }
        
    }    
}
