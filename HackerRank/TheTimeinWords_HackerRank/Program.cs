namespace TheTimeinWords_HackerRank
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
         * Complete the 'timeInWords' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER h
         *  2. INTEGER m
         */

        public static string TimeInWords(int h, int m)
        {
            string[] hrs = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
            string[] mins = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
                                    "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one",
                                    "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight",
                                    "twenty nine"};
            string result = null;
            if (m.ToString() == "0") result = hrs[h - 1] + " o' clock";
            else if (m.ToString() == "15") result = "quarter past " + hrs[h - 1];
            else if (m.ToString() == "30") result = "half past " + hrs[h - 1];
            else if (m.ToString() == "45") result = "quarter to " + hrs[h];
            else if (m == 1) result = mins[m - 1] + " minute past " + hrs[h - 1];
            else if (m < 30) result = mins[m - 1] + " minutes past " + hrs[h - 1];
            else if (m == 59) result = mins[59 - m] + " minute to " + hrs[h];
            else if (m > 30) result = mins[59 - m] + " minutes to " + hrs[h];
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.TimeInWords(5, 10));
            int h = Convert.ToInt32(Console.ReadLine().Trim());
            int m = Convert.ToInt32(Console.ReadLine().Trim());
            string result = Result.TimeInWords(h, m);
            Console.WriteLine(result);
        }
    }
}
