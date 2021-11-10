namespace Flip
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Flip(string A)
        {
            #region Solution 1 - Brute Force - O(N^2)
            //var countOf1s = CountNumberOf1s(A);
            //var list = new List<int> { };
            //for (int i = 1; i <= A.Length; i++)
            //{
            //    for (int j = i; j <= A.Length; j++)
            //    {
            //        string str = BitReversal(A, i, j);
            //        int tempCountOf1s = CountNumberOf1s(str);
            //        if (tempCountOf1s > countOf1s)
            //        {
            //            countOf1s = tempCountOf1s;
            //            list.Clear();
            //            list.Add(i);
            //            list.Add(j);
            //        }
            //    }
            //}
            //return list;
            #endregion

            #region Solution 2 - O(N)
            int count = 0; int maxCount = 0; int left = 0, right = 0, leftTemp = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '0') count++;
            }
            if (count == 0) return new List<int>();

            count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '0') count++;
                else count--;
                if (count > maxCount)
                {
                    maxCount = count;
                    left = leftTemp;
                    right = i;
                }
                if (count < 0)
                {
                    count = 0;
                    leftTemp = i + 1;
                }
            }
            return new List<int> { left + 1, right + 1 };
            #endregion
        }

        public static int CountNumberOf1s(string A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '1') count++;
            }
            return count;
        }

        public static string BitReversal(string A, int start, int end)
        {
            char[] str = new char[A.Length];
            for (int i = start - 1; i <= end - 1; i++)
            {
                if (A[i] == '1')
                {
                    str[i] = '0';
                }
                else str[i] = '1';
            }
            return A.Substring(0, start - 1) + new string(str).Substring(start - 1, end - start + 1) + A.Substring(end);
        }

        static void Main(string[] args)
        {
            Flip("1101010001").ForEach(x => Console.WriteLine(x));
        }
    }
}
