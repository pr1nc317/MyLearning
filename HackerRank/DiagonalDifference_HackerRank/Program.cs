﻿namespace DiagonalDifference_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        class Result
        {

            /*
             * Complete the 'diagonalDifference' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts 2D_INTEGER_ARRAY arr as parameter.
             */

            public static int diagonalDifference(List<List<int>> arr)
            {
                int diag1Sum = 0, diag2Sum = 0;
                for (int i = 0, j = arr.Count-1; i < arr.Count; i++, j--)
                {
                    diag1Sum += arr[i][i];
                    diag2Sum += arr[i][j];
                }
                return Math.Abs(diag1Sum - diag2Sum);
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);
        }
    }
}
