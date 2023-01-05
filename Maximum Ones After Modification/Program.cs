namespace Maximum_Ones_After_Modification
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Solve(List<int> A, int B)
        {
            int flip = 0;
            int i = 0;
            int j = 0;
            int ans = 0;
            while (i < A.Count)
            {
                if (A[i] == 0)
                    flip++;
                while (flip > B)
                {
                    if (A[j] == 0)
                        flip--;
                    j++;
                }
                ans = Math.Max(ans, i - j + 1);
                i++;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1, 0, 0, 1, 1, 0, 1 }, 1));
            Console.WriteLine(Solve(new List<int> { 1, 0, 0, 1, 0, 1, 0, 1, 0, 1 }, 2));
        }
    }
}
