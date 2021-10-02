namespace SavethePrisoner__HackerRank
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
         * Complete the 'saveThePrisoner' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER m
         *  3. INTEGER s
         */

        public static int SaveThePrisoner(int n, int m, int s)
        {
            //Solution 1 - One Liner
            //return ((m - 1 + s - 1) % n) + 1;

            //Solution 2 - Easy to Understand
            var remainder = m % n;
            if ((remainder + s - 1) % n == 0)
            {
                return n;
            }
            else return (remainder + s - 1) % n;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.SaveThePrisoner(208526924, 756265725, 150817879));

            var lines = File.ReadAllLines(@"C:\Users\shaami\OneDrive - Microsoft\Desktop\Practice.txt");
            foreach (var item1 in lines)
            {
                var item = item1.Split(',');
                Console.WriteLine(Result.SaveThePrisoner(int.Parse(item[0]), int.Parse(item[1]), int.Parse(item[2]))); 
            }

            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int m = Convert.ToInt32(firstMultipleInput[1]);
                int s = Convert.ToInt32(firstMultipleInput[2]);
                int result = Result.SaveThePrisoner(n, m, s);
                Console.WriteLine(result);
            }
        }
    }

}
