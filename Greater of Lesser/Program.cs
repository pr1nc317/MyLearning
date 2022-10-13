namespace Greater_of_Lesser
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A, List<int> B, int C)
        {
            int ans1 = 0;int ans2 = 0;
            int i; int j;
            for (i=0, j=0; i < A.Count || j < B.Count; i++, j++)
            {
                if (i < A.Count)
                {
                    if (A[i] > C)
                    {
                        ans1++;
                    }
                }
                if (j < B.Count)
                {
                    if (B[i] < C)
                    {
                        ans2++;
                    }
                }
            }
            return Math.Max(ans1, ans2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1, 10, 100, 110 }, new List<int> { 9, 9, 9 }, 50));
        }
    }
}
