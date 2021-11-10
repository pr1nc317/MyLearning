namespace Max_MIn
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A)
        {
            int max = int.MinValue; int min = int.MaxValue;
            for (int i =0; i < A.Count; i++)
            {
                if (A[i] < min) min = A[i];
                if (A[i] > max) max = A[i];
            }
            return max + min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { -2, 1, -4, 5, 3 }));
        }
    }
}
