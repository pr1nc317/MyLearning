namespace SherlockandSquares_HackerRank
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {

        /*
         * Complete the 'squares' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER a
         *  2. INTEGER b
         */

        public static int Squares(int a, int b)
        {
            var result = 0;
            for (int i = a; i <= b; i++)
            {
                var sqrt = Math.Sqrt(i);
                var sqrtCeiling = Math.Ceiling(sqrt);
                if (sqrt == sqrtCeiling)
                {
                    result++;
                    var limit = Math.Sqrt(b);
                    for (i = (int)sqrt + 1; i <= limit; i++)
                    {
                        if (i*i <= b)
                        {
                            result++;
                        }
                    }
                    break;
                }
            }
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());
            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int a = Convert.ToInt32(firstMultipleInput[0]);
                int b = Convert.ToInt32(firstMultipleInput[1]);
                int result = Result.Squares(a, b);
                Console.WriteLine(result);
            }
        }
    }

}
