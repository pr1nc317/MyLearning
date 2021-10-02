namespace Taum_and_B_day_HackerRank
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
         * Complete the 'taumBday' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER b
         *  2. INTEGER w
         *  3. INTEGER bc
         *  4. INTEGER wc
         *  5. INTEGER z
         */

        public static long TaumBday(long b, long w, long bc, long wc, long z)
        {
            long result;
            long exchangePrice; long totalBuyPrice;
            if (Math.Abs(bc - wc) > z)
            {
                totalBuyPrice = Math.Min(bc, wc) * (b + w);
                //exchangePrice
                if (bc >= wc)
                {
                    exchangePrice = b * z;
                }
                else exchangePrice = w * z;
                result = totalBuyPrice + exchangePrice;
            }
            else
            {
                result = (b * bc) + (w * wc);
            }
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.TaumBday(27984, 1402, 619246, 615589, 247954));
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int b = Convert.ToInt32(firstMultipleInput[0]);
                int w = Convert.ToInt32(firstMultipleInput[1]);
                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int bc = Convert.ToInt32(secondMultipleInput[0]);
                int wc = Convert.ToInt32(secondMultipleInput[1]);
                int z = Convert.ToInt32(secondMultipleInput[2]);
                long result = Result.TaumBday(b, w, bc, wc, z);
                Console.WriteLine(result);
            }
        }
    }
}
