namespace Minimum_Lights_to_Activate
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            var index = A.IndexOf(1);
            if (index < 0) return -1;
            if (index >= 0 && B > A.Count) return 1;
            int right, count = 1;
            for (int i = Math.Min(B - 1, A.Count - 1); index <= i; i--)
            {
                if (A[i] != 1) continue;
                right = i + B - 1;
                if (right >= A.Count - 1) return count;
                int j = Math.Min(i + (2 * B) - 1, A.Count - 1);
                while (A[j] != 1)
                {
                    j--;
                    if (j == i) return -1;
                }
                i = j + 1;
                count++;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Solve(new List<int> { 1, 0, 1, 0, 0, 0 }, 4);
        }
    }
}
