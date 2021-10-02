namespace BiggerisGreater_HackerRank
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
         * Complete the 'biggerIsGreater' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING w as parameter.
         */

        public static string BiggerIsGreater(string w)
        {
            //Step 1 - find pivotal index which satisfies the condition that a char is greater than its preceding char (from reverse direction)
            int pivotalIndex = 0; bool flag = false;
            var sb = new StringBuilder();
            for (int i = w.Length-1; i >= 1; i--)
            {
                if (w[i] > w[i - 1])
                {
                    pivotalIndex = i - 1;
                    flag = true;
                    sb.Append(w[i]);
                    break;
                }
                sb.Append(w[i]);
            }
            if (!flag) return "no answer";
            //Step 2 - find the rightmost greatest char from this pivotal index and swap them
            string swappedString = null;
            for (int i = w.Length-1; i> pivotalIndex;  i--)
            {
                if (w[i] > w[pivotalIndex])
                {
                    var temp = w[pivotalIndex];
                    var wToList = w.ToList();
                    wToList[pivotalIndex] = w[i];
                    wToList[i] = temp;
                    sb[w.Length - 1 - i] = temp;
                    swappedString = string.Join("", wToList);
                    break;
                }
            }
            //Step 3 - reverse the order of the characters to the right of pivotal index (basically sort them in asc order)
            var sortedStringAfterPivotalIndex = sb.ToString().Reverse().ToList();
            sortedStringAfterPivotalIndex.Sort();
            var stringFromPivotalIndex = string.Join("", sortedStringAfterPivotalIndex);
            var stringBeforePivotalIndex = new StringBuilder();
            for (int i = 0; i <= pivotalIndex;  i++)
            {
                stringBeforePivotalIndex.Append(swappedString[i]);
            }
            stringFromPivotalIndex = stringFromPivotalIndex.Insert(0, stringBeforePivotalIndex.ToString());
            return stringFromPivotalIndex;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Result.BiggerIsGreater("fedcbabcd");
            int T = Convert.ToInt32(Console.ReadLine().Trim());
            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();
                string result = Result.BiggerIsGreater(w);
                Console.WriteLine(result);
            }
        }
    }
}