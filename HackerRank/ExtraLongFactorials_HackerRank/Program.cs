namespace ExtraLongFactorials_HackerRank
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
    using System.Numerics;

    class Result
    {

        /*
         * Complete the 'extraLongFactorials' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        //First Way - Delegate/Lambda
        public static void ExtraLongFactorials(int n)
        {
            Func<int, BigInteger> factorial = null; 
            factorial = x => x <= 1 ? 1 : x * factorial(x - 1);
            Console.WriteLine(factorial(n));
        }

        //Second Way - Recursion
        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Result.ExtraLongFactorials(25);
            Console.WriteLine(Result.Factorial(8));
        }
    }

}
