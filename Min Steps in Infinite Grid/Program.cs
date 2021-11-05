namespace Min_Steps_in_Infinite_Grid
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int CoverPoints(List<int> A, List<int> B)
        {
            int step = 0;
            for (int i = 1; i < A.Count; i++)
            {
                step += Math.Max(Math.Abs(A[i] - A[i - 1]), Math.Abs(B[i] - B[i - 1]));
            }
            return step;
        }

        static void Main(string[] args)
        {
            CoverPoints(new List<int> { 4, 8, -7, -5, -13, 9, -7, 8 }, new List<int> { 4, -15, -10, -3, -13, 12, 8, -8 });
        }
    }
}
