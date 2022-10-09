namespace Climbing_Stairs
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A)
        {
            int[] dp = new int[A.Count];
            dp[A.Count - 1] = A[A.Count - 1];
            dp[A.Count - 2] = A[A.Count - 2] + A[A.Count - 1];
            for (int i = A.Count -3; i >= 0; i--)
            {
                dp[i] = Math.Min(dp[i + 1], dp[i + 2]) + A[i];
            }
            return dp[0];
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Solve(new List<int> { 1, 2, 1, 1, 4, 2 }));
            //Console.WriteLine(Solve(new List<int> { 4, 1, 2, 3, 4 }));
            Console.WriteLine(Solve(new List<int> { 5, 68, 68, 94, 39, 52, 84, 4, 6, 53, 68, 1, 39, 7, 42, 69, 59, 94, 85, 53, 10, 66, 42, 71, 92, 77, 27, 5, 74, 33, 64, 76, 100, 37, 25, 99, 73, 76, 66, 8, 64, 89, 28, 44, 77, 48, 24, 28, 36, 17, 49, 90, 3, 7 }));
        }
    }
}
