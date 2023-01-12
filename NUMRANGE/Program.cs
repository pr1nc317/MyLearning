namespace NUMRANGE
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int NumRange(List<int> A, int B, int C)
        {
            return SubArraysCountHavingSumLessThanEqualTo(A, C) - SubArraysCountHavingSumLessThanEqualTo(A, B - 1);
        }

        public static int SubArraysCountHavingSumLessThanEqualTo(List<int> A, int B)
        {
            int i = 0, j = 0;
            int count = 0; int sum = 0;
            while (i < A.Count)
            {
                sum += A[i];
                while (sum > B && j <= i)
                {
                    sum -= A[j]; j++;
                }
                count += i - j + 1;
                i++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(NumRange(new List<int> { 10, 5, 1, 0, 2 }, 6, 8));
            Console.WriteLine(NumRange(new List<int> { 80, 97, 78, 45, 23, 38, 38, 93, 83, 16, 91, 69, 18, 82, 60, 50, 61, 70, 15, 6, 52, 90 }, 99, 269));
        }
    }
}
