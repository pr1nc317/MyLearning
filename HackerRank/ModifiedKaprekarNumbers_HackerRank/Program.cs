namespace ModifiedKaprekarNumbers_HackerRank
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
         * Complete the 'kaprekarNumbers' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER p
         *  2. INTEGER q
         */

        public static void KaprekarNumbers(long p, long q)
        {
            char[] squareSplit;
            var result = new StringBuilder();
            for (long i = p; i <= q; i++)
            {
                var sbR = new StringBuilder(string.Empty);
                var sbL = new StringBuilder();
                long length = i.ToString().Length;
                long square = i * i;
                squareSplit = square.ToString().ToCharArray();
                for (int j = squareSplit.Length - 1; sbR.ToString().Length < length; j--)
                {
                    sbR.Append(squareSplit[j]);
                }
                for (int j = 0; j < squareSplit.Length - length; j++)
                {
                    sbL.Append(squareSplit[j]);
                }
                if (string.IsNullOrEmpty(sbL.ToString()))
                {
                    sbL.Append(0);
                }
                long additionAfterSplit = long.Parse(string.Join("", sbR.ToString().Reverse())) + long.Parse(sbL.ToString());
                if (additionAfterSplit == i) result.Append(i + " ");
            }
            if (string.IsNullOrEmpty(result.ToString().Trim()))
            {
                Console.WriteLine("INVALID RANGE");
            }
            else Console.WriteLine(result.ToString().Trim());
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //int p = Convert.ToInt32(Console.ReadLine().Trim());
            //int q = Convert.ToInt32(Console.ReadLine().Trim());
            Result.KaprekarNumbers(400, 700);
        }
    }
}
