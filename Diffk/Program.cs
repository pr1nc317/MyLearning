namespace Diffk
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int DiffPossible(List<int> A, int B)
        {
            for (int i = 0, j = i + 1; i < j & i < A.Count - 1 & j < A.Count;)
            {
                if (Math.Abs(A[i] - A[j]) < B)
                {
                    j++; continue;
                }
                if (Math.Abs(A[i] - A[j]) > B)
                {
                    i++;
                    if (i == j) j++;
                    continue;
                }
                return 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(DiffPossible(new List<int> { 1, 3, 5 }, 4));
            Console.WriteLine(DiffPossible(new List<int> { -3, -2, -1, 0, 3, 4, 5, 6 }, 10));
        }
    }
}
