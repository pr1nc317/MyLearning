namespace MinimumDistances_HackerRank
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
         * Complete the 'minimumDistances' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */
        public static int MinimumDistances(List<int> a)
        {
            int result = int.MaxValue;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        result = Math.Min(result, j - i);
                    }
                }
            }
            if (result > a.Count) return -1;
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            var list = File.ReadAllLines(Environment.CurrentDirectory + @"/TextFile1.txt").Select(x=> int.Parse(x)).ToList();
            Console.WriteLine(Result.MinimumDistances(list));
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int result = Result.MinimumDistances(a);
            Console.WriteLine(result);
        }
    }
}
