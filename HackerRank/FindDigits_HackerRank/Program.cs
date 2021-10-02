namespace FindDigits_HackerRank
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
         * Complete the 'findDigits' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int FindDigits(int n)
        {
            return n.ToString().ToArray().Select(x => int.Parse(x.ToString())).OrderBy(x => x).SkipWhile(x=> x==0).Where(x=> n%x==0).Count();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.FindDigits(1012));
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                int result = Result.FindDigits(n);
                Console.WriteLine(result);
            }
        }
    }

}
