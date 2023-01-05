namespace Counting_Subarrays_
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Solve(List<int> A, int B)
        {
            int i = 0;
            int j = 0;
            int ans = 0;
            int currSum = 0;
            while (i < A.Count)
            {
                if (A[i] < B)
                {
                    ans++;
                }
                else if (A[i] >= B)
                {
                    i++;
                    j = i;
                    continue;
                }
                currSum += A[i];
                while (currSum >= B)
                {
                    currSum -= A[j];
                    j++;
                }
                if (i > j)
                    ans += i - j;
                i++;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 2, 5, 6 }, 10));
            Console.WriteLine(Solve(new List<int> { 1, 11, 2, 3, 15 }, 10));
            Console.WriteLine(Solve(new List<int> { 2, 5, 6, 4, 8, 10 }, 15));
        }
    }
}
