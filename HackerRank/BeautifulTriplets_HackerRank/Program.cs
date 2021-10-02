namespace BeautifulTriplets_HackerRank
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
         * Complete the 'beautifulTriplets' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER d
         *  2. INTEGER_ARRAY arr
         */

        public static int BeautifulTriplets(int d, List<int> arr)
        {
            int magicTriplet = 0;
            for (int i = arr.Count-1; i>=2; i--)
            {
                magicTriplet += arr.Where(x => arr[i] - x == d).Count() * arr.Where(x => arr[i] -x == 2*d).Count();
            }
            return magicTriplet;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Result.BeautifulTriplets(3, new List<int> { 1, 6, 7, 7, 8, 10, 10, 12, 13, 14, 19 });
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int d = Convert.ToInt32(firstMultipleInput[1]);
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = Result.BeautifulTriplets(d, arr);
            Console.WriteLine(result);
        }
    }
}
