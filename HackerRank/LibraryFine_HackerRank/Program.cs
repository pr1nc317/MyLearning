namespace LibraryFine_HackerRank
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
         * Complete the 'libraryFine' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER d1
         *  2. INTEGER m1
         *  3. INTEGER y1
         *  4. INTEGER d2
         *  5. INTEGER m2
         *  6. INTEGER y2
         */

        public static int LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine = 0;
            if (y1 - y2 >= 1)
            {
                fine = 10000;
            }
            else if (m1 - m2 >= 1 && (y1 - y2 >= 0))
            {
                fine = 500 * (m1 - m2);
            }
            else if (d1 - d2 >= 1 && (m1 - m2 >= 0 ) && (y1 - y2 >=0))
            {
                fine = 15 * (d1 - d2);
            }
            return fine;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int d1 = Convert.ToInt32(firstMultipleInput[0]);
            int m1 = Convert.ToInt32(firstMultipleInput[1]);
            int y1 = Convert.ToInt32(firstMultipleInput[2]);
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int d2 = Convert.ToInt32(secondMultipleInput[0]);
            int m2 = Convert.ToInt32(secondMultipleInput[1]);
            int y2 = Convert.ToInt32(secondMultipleInput[2]);
            int result = Result.LibraryFine(d1, m1, y1, d2, m2, y2);
            Console.WriteLine(result);
        }
    }

}
