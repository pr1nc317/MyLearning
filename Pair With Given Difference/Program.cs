namespace Pair_With_Given_Difference
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            #region Approach 1 - Sorting + Two Pointers
            //A.Sort();
            //int j = A.Count - 1;
            //for (; j > 0; j--)
            //{
            //    for (int i = 0; i < j; i++)
            //    {
            //        if (A[j] - A[i] == Math.Abs(B))
            //            return 1;

            //        if (A[j] - A[i] < Math.Abs(B))
            //            break;
            //    }
            //}
            //return 0;
            #endregion

            #region Approach 2 - HashSet
            HashSet<int> hashSet = new HashSet<int>();
            foreach (var item in A)
            {
                if (hashSet.Contains(item))
                    return 1;
                else hashSet.Add(Math.Abs(B + item));
            }
            return 0;
            #endregion
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Solve(new List<int> { 5, 10, 3, 2, 50, 80 }, 78));
            //Console.WriteLine(Solve(new List<int> { 50, -10, 20, 30, 40, -15 }, 30));
            Console.WriteLine(Solve(new List<int> { -259, -825, 459, 825, 221, 870, 626, 934, 205, 783, 850, 398 }, -42));
        }
    }
}
