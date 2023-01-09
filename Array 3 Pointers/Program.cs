namespace Array_3_Pointers
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Minimize(List<int> A, List<int> B, List<int> C)
        {
            int i = 0, j = 0, k = 0;
            int diff;
            int minDiff = int.MaxValue;
            while (i < A.Count && j < B.Count && k < C.Count)
            {
                int minAB = Math.Min(A[i], B[j]);
                int min = Math.Min(C[k], minAB);
                int maxAB = Math.Max(A[i], B[j]);
                int max = Math.Max(C[k], maxAB);
                diff = Math.Abs(max - min);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
                if (A[i] == min) i++;
                else if (B[j] == min) j++;
                else k++;
            }
            return minDiff;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Minimize(new List<int> { 1, 4, 10 }, new List<int> { 2, 15, 20 }, new List<int> { 10, 12}));
        }
    }
}
