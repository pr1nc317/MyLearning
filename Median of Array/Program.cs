namespace Median_of_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static double FindMedianSortedArrays(List<int> a, List<int> b)
        {
            int m = a.Count;
            int n = b.Count;
            if (m > n) return FindMedianSortedArrays(b, a);
            int combinedMid = (m + n + 1) / 2;
            int start = 0;
            int end = m;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int balanceMid = combinedMid - mid;
                int leftA = mid > 0 ? a[mid - 1] : int.MinValue;
                int leftB = balanceMid > 0 ? b[balanceMid - 1] : int.MinValue;
                int rightA = mid < m ? a[mid] : int.MaxValue;
                int rightB = balanceMid < n ? b[balanceMid] : int.MaxValue;

                if (leftA <= rightB && leftB <= rightA)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(leftB, leftA) + Math.Min(rightB, rightA)) / 2.0;
                    }
                    else return Math.Max(leftA, leftB);
                }
                else if (leftA > rightB) end = mid - 1;
                else start = mid + 1;
            }
            return 0.0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindMedianSortedArrays(new List<int> { 1, 4, 5 }, new List<int> { 2, 3 }));
        }
    }
}
