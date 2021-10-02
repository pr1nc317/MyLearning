namespace ChocolateFeast_HackerRank
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
         * Complete the 'chocolateFeast' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER c
         *  3. INTEGER m
         */

        public static int ChocolateFeast(int n, int c, int m)
        {
            var bars = n / c;
            var swappedBars = 0; var wrappersLeft = bars;
            for (;;)
            {
                swappedBars = wrappersLeft / m;
                wrappersLeft = swappedBars + wrappersLeft % m;
                bars += swappedBars;
                if (wrappersLeft < m) break;
            }
            return bars;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.ChocolateFeast(10, 2, 5));
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int c = Convert.ToInt32(firstMultipleInput[1]);
                int m = Convert.ToInt32(firstMultipleInput[2]);
                int result = Result.ChocolateFeast(n, c, m);
                Console.WriteLine(result);
            }
        }
    }
}
