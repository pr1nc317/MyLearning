namespace Lisa_sWorkbook_HackerRank
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
         * Complete the 'workbook' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY arr
         */

        public static int Workbook(int n, int k, List<int> arr)
        {
            int page = 0;
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                page++;
                for (int j = 1; j <= arr[i-1]; j++)
                {
                    if (page == j) result++;
                    if (j % k == 0 && j != arr[i-1]) page++;
                }
            }
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.Workbook(5, 3, new List<int> { 4, 2, 6, 1, 10 }));
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.Workbook(n, k, arr);

            Console.WriteLine(result);
        }
    }

}
