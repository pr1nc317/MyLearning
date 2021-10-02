namespace RepeatedString_HackerRank
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
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long RepeatedString(string s, long n)
        {
            var remainder = n % s.Length;
            var countOfA = s.ToCharArray().Where(x => x == 'a').Count()*(n/s.Length);
            for (int i = 0; i<remainder; i++)
            {
                if (s[i] == 'a') countOfA++;
            }
            return countOfA;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            var result1 = Result.RepeatedString("a", 1000000);
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            long result = Result.RepeatedString(s, n);
            Console.WriteLine(result);
        }
    }
}
