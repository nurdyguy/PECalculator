using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Diagnostics;

using _calc = MathService.Calculators.Calculator;

namespace ProblemService.Problems
{
    public class Problem_18 : Problem
    {
        //https://projecteuler.net/problem=18 Published on Friday, 19th April 2002, 05:00 pm; Solved by 160026; Difficulty rating: 5% --- completed
        //                                      
        //  By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
        //
        //            3
        //           7 4
        //          2 4 6
        //         8 5 9 3
        //
        //    That is, 3 + 7 + 4 + 9 = 23.
        //
        // Find the maximum total from top to bottom of the triangle below:
        //
        // NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route. 
        // However, Problem 67, is the same challenge with a triangle containing one-hundred rows; it cannot be solved by brute force, and requires a clever method! ;o)

        private List<List<int>> trinagle = new List<List<int>>
        {
            new List<int>{                                  75                                               },
            new List<int>{                                95,  64                                            },
            new List<int>{                              17,  47,  82                                         },
            new List<int>{                            18,  35,  87,  10                                      },
            new List<int>{                          20,  04,  82,  47,  65                                   },
            new List<int>{                        19,  01,  23,  75,  03,  34                                },
            new List<int>{                      88,  02,  77,  73,  07,  63,  67                             },
            new List<int>{                    99,  65,  04,  28,  06,  16,  70,  92                          },
            new List<int>{                  41,  41,  26,  56,  83,  40,  80,  70,  33                       },
            new List<int>{                41,  48,  72,  33,  47,  32,  37,  16,  94,  29                    },
            new List<int>{              53,  71,  44,  65,  25,  43,  91,  52,  97,  51,  14                 },
            new List<int>{            70,  11,  33,  28,  77,  73,  17,  78,  39,  68,  17,  57              },
            new List<int>{          91,  71,  52,  38,  17,  14,  91,  43,  58,  50,  27,  29,  48           },
            new List<int>{        63,  66,  04,  68,  89,  53,  67,  30,  73,  16,  69,  87,  40,  31        },
            new List<int>{      04,  62,  98,  27,  23,  09,  70,  98,  73,  93,  38,  53,  60,  04,  23     }
        };

        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var currIndex = 0;
            var currLevel = 0;
            var sum = trinagle[currLevel][currIndex];

            while(currLevel < trinagle.Count() - 1)
                if (trinagle[currLevel + 1][currIndex] > trinagle[currLevel + 1][currIndex + 1])
                {
                    Debug.WriteLine($"{currLevel + 1} - {trinagle[currLevel + 1][currIndex]}");
                    sum += trinagle[++currLevel][currIndex]; 
                }
                else if (trinagle[currLevel + 1][currIndex] < trinagle[currLevel + 1][currIndex + 1])
                {
                    Debug.WriteLine($"{currLevel + 1} - {trinagle[currLevel + 1][currIndex + 1]}");
                    sum += trinagle[++currLevel][++currIndex];
                }
                else
                {
                    Debug.WriteLine($"TIE --- {++currLevel} - {currIndex}");
                }

            return new { sum };
        }
        
        
    }    
}
