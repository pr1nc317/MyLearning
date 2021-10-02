namespace JumpingontheClouds_HackerRank
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
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int JumpingOnClouds(List<int> c)
        {
            int jump = 0;
            for (int i = 0; i <= c.Count-2;)
            {
                if (i == c.Count - 2)
                {
                    return ++jump;
                }
                if (c[i + 2] == 0)
                {
                    i += 2;
                    jump++;
                }
                else
                {
                    i++;
                    jump++;
                }
            }
            return jump;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.JumpingOnClouds(new List<int> { 0,0}));
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();
            int result = Result.JumpingOnClouds(c);
            Console.WriteLine(result);
        }
    }
}