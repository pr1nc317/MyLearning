namespace Noble_Integer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A)
        {
            #region Solution 1 - O(N^2)
            //int count;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    count = 0;
            //    for (int j = 0; j < A.Count; j++)
            //    {
            //        if (A[j] > A[i])
            //        {
            //            count++;
            //        }
            //    }

            //    if (A[i] == count) return 1;
            //}
            //return -1;
            #endregion

            #region Solution 2 - O(N + NLogN)
            A.Sort();
            if (A.Max() == 0) return 1;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == A.Count - 1 - i && A[i + 1] != A[i])
                {
                    return 1;
                }
            }
            return -1;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { -1, -7, 5, 7, -10, 8, 1, -1, -1, -3, -2, 2, 5, -7, -6, -1, 0, -8, -10, -9, -1, -4, 2, -9, -8, -10, 7, -7, -9, -9, -1, 0, -5, 6, -3, 7, 4, 0, -4, -6, 7, 4, -2, -5, 8, 2, -4, -10, -4, -4, 4, 6, 2, 8, -1, -4, 0, -3, 0, 1, -10, 1, 3, 7, -3, 2, -4, 4, 5, 2, 0, 2, 9, 0, -1, -1, 4, 5, -9, -10, 3, -3, -2, 8, -4, 0 }));
        }
    }
}
