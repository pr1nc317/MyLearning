namespace Cutthesticks_HackerRank
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
         * Complete the 'cutTheSticks' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> CutTheSticks(List<int> arr)
        {
            var resulList = new List<int>();
            //int subtractor = 0;
            arr.Sort();
            for (int i = 0; arr.Count != 0; i++)
            {
                //subtractor = arr[0];
                //for (int j= 0; j<arr.Count; j++)
                //{
                //    arr[j] -= subtractor;
                //}
                arr = arr.Select(x => x - arr[0]).ToList();
                resulList.Add(arr.Count());
                //resulList.Add(arr.Count);
                arr = arr.Where(x => x != 0).ToList();
            }
            return resulList;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Result.CutTheSticks(new List<int> { 1, 2, 3, 4, 3, 3, 2, 1 });
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> result = Result.CutTheSticks(arr);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
