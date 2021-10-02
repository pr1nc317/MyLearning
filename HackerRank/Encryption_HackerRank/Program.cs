namespace Encryption_HackerRank
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
         * Complete the 'encryption' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string Encryption(string s)
        {
            var stringToEncrpt = string.Join("", s.Split(' ').ToList().Where(x => x != ""));
            var length = stringToEncrpt.Length;
            var rootLength = Math.Sqrt(length);
            var columns = (int)Math.Ceiling(rootLength);
            var rows = Math.Floor(rootLength) * columns >= length ? (int)Math.Floor(rootLength) : (int)Math.Floor(rootLength) + 1;
            var resultArray = new string[rows, columns];
            var result = new StringBuilder();
            for (int i = 0; i < columns; i++)
            {
                for (int j = i; j % columns == i && j < length; j += columns)
                {
                    result.Append(stringToEncrpt[j]);
                }
                result.Append(" ");
            }
            return result.ToString().Remove(result.Length - 1);
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.Encryption("haveaniceday"));
            string s = Console.ReadLine();
            string result = Result.Encryption(s);
            Console.WriteLine(result);
        }
    }
}
