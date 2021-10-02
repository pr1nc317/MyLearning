namespace Non_DivisibleSubset_HackerRank
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
         * Complete the 'nonDivisibleSubset' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY s
         */

        public static int NonDivisibleSubset(int k, List<int> s)
        {
            var result = 0;
            //if (k == 1) return 0;
            //Create a frequency array (initialize with value 0)
            var freqArray = new int[k];
            for (int i = 0; i < k; i++)
            {
                freqArray[i] = 0;
            }
            //Populate actual frequency values to each element of the frequency array
            for (int i = 0; i < s.Count; i++)
            {
                freqArray[s[i] % k]++;
            }
            //For 0th index, always select at max 1 or minimum 0 (if frequency array is empty)
            result += k % 2 == 0 ? (freqArray[0] > 0 ? 1 : 0) + (freqArray[k / 2] > 0 ? 1 : 0) : (freqArray[0] > 0 ? 1 : 0);
            //For selecting the minimun through frequency array for all other indices (remainders)
            //Range to traverse should be from 1 to (k-1/2) for even k and 1 to k/2 for odd k.
            for (int i = 1; i <= (k - 1 / 2) && i < k - i; i++)
            {
                result += Math.Max(freqArray[i], freqArray[k - i]);
            }
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.NonDivisibleSubset(3, new List<int> { 1,7,2,4}));
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            int result = Result.NonDivisibleSubset(k, s);
            Console.WriteLine(result);
        }
    }
}