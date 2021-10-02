namespace CircularArrayRotation_HackerRank
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
         * Complete the 'circularArrayRotation' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER k
         *  3. INTEGER_ARRAY queries
         */

        public static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
        {
            //Array or any enumeration of lets say - {1, 2, 3} of count 3 after 2 rotations will be - {2, 3, 1}
            //The new array will start from some particular index of the original array
            //and that particular index will be: Array Count - Number of rotations i.e., (3 - 2) = 1
            //So new array's first element (0th index) will be 1st index of original array

            int rotations = k % a.Count;
            var result = new List<int>();
            foreach (var item in queries)
            {
                result.Add(a[(a.Count-rotations+item)%a.Count]);
            }
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            int q = Convert.ToInt32(firstMultipleInput[2]);
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> queries = new List<int>();
            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }
            List<int> result = Result.CircularArrayRotation(a, k, queries);
        }
    }

}
