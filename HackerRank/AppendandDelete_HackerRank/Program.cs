namespace AppendandDelete_HackerRank
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
         * Complete the 'appendAndDelete' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. STRING t
         *  3. INTEGER k
         */

        public static string AppendAndDelete(string s, string t, int k)
        {
            //string 1 and string 2 might have some common characters
            //Step 1 - count the number of common characters amongst s and t
            //Step 2 - subtract the twice of common characters (twice because we will remove and add to a string) from total characters
            //and check if the result is less than k or not (k being the number of operations allowed).
            //Step 3 - the above two steps, if true, should also be checked along side another validation which is:
            //number of operations and total length of the characters should be in circular sync, i.e k%2 and total_length%2 should be equal
            //If all the above steps are true, return YES else NO
            //OR if above steps did not return true but total_length is less than k operations, even then we can return true because we can
            //delete the whole string and rewrite it

            var totalLength = s.Length + t.Length;
            var counter = 0;
            for (int i = 0, j = 0; i<s.Length && j<t.Length; i++, j++)
            {
                if (s[i] == t[j]) counter++;
                else break;
            }
            if ((totalLength - 2 * counter <= k) && (k % 2 == totalLength % 2) || totalLength < k)
            {
                return "Yes";
            }
            else return "No";
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine().Trim());
            string result = Result.AppendAndDelete(s, t, k);
            Console.WriteLine(result);
        }
    }

}
