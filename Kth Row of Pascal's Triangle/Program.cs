namespace Kth_Row_of_Pascal_s_Triangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> KthRowOfPascalTriangle(int k)
        {
            #region Solution 1 - Using Recursion
            //var curr = new List<int> { 1 };
            //if (k == 0) return curr;

            //var prev = KthRowOfPascalTriangle(k - 1);

            //for (int i = 1; i < prev.Count; i++)
            //{
            //    int num = prev[i] + prev[i - 1];
            //    curr.Add(num);
            //}
            //curr.Add(1);
            //return curr;
            #endregion

            #region Solution 2 - O(n) with O(1) space
            // We can use combination formula here
            // First element of kth row is kC0, second element is kC1 and last element is kCk
            // Now kCr combination formula can also be written as (kCr-1 * (k - r + 1))/r

            var list = new List<int>();
            int prev = 1;
            list.Add(prev);
            for (int i = 1; i <= k; i++)
            {
                prev = (prev * (k - i + 1))/ i;
                list.Add(prev);
            }
            return list;
            #endregion
        }

        static void Main(string[] args)
        {
            KthRowOfPascalTriangle(4).ForEach(x => Console.WriteLine(x));
        }
    }
}
