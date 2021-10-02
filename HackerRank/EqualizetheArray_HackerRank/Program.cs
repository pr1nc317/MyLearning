namespace EqualizetheArray_HackerRank
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
         * Complete the 'equalizeArray' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int EqualizeArray(List<int> arr)
        {
            Dictionary<int, int> dictForMaintainingCount = new Dictionary<int, int>();
            arr.Distinct().ToList().ForEach(x => dictForMaintainingCount.Add(x,0));
            //arr.ForEach(x => dictForMaintainingCount.TryAdd(x, arr.Where(y => y == x).Count()));
            arr.ForEach(x => dictForMaintainingCount[x]++);
            var maxCountOfAnyNumberInOriginalList = dictForMaintainingCount.OrderByDescending(y => y.Value).ToList()[0].Value;
            return arr.Count - maxCountOfAnyNumberInOriginalList;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.EqualizeArray(new List<int> { 3, 4, 5, 6, 7, 2, 1, 1 }));
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int result = Result.EqualizeArray(arr);
            Console.WriteLine(result);
        }
    }
}
