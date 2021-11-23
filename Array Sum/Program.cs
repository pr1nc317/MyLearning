namespace Array_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        #region Solution 1
        //public static List<int> AddArrays(List<int> A, List<int> B)
        //{
        //    int aCount = A.Count;
        //    int bCount = B.Count;
        //    int maxCount = Math.Max(aCount, bCount);
        //    int carry = 0;
        //    var ans = new List<int>();

        //    if (aCount != bCount)
        //    {
        //        if (aCount < bCount)
        //        {
        //            int diff = bCount - aCount;
        //            A = Enumerable.Repeat(0, diff).Concat(A).ToList();
        //        }
        //        else if (aCount > bCount)
        //        {
        //            int diff = aCount - bCount;
        //            B = Enumerable.Repeat(0, diff).Concat(B).ToList();
        //        }
        //    }

        //    for (int i = maxCount - 1; i >= 0; i--)
        //    {
        //        int sum = A[i] + B[i] + carry;
        //        carry = sum / 10;
        //        int eleToAdd = sum % 10;
        //        ans.Insert(0, eleToAdd);
        //    }

        //    if (carry > 0)
        //        ans.Insert(0, carry);

        //    return ans;
        //}
        #endregion


        #region Solution 2

        public static List<int> AddArrays(List<int> A, List<int> B)
        {
            List<int> list;
            if (A.Count > B.Count)
                list = A;
            else list = B;

            int carry = 0;
            int listCount = list.Count;

            for (int i = 0; i < listCount; i++)
            {
                if (i < A.Count)
                {
                    carry += A[A.Count - 1 - i];
                }
                if (i < B.Count)
                {
                    carry += B[B.Count - 1 - i];
                }
                list[listCount - 1 - i] = carry % 10;
                carry /= 10;
            }

            if (carry == 1) list.Insert(0, carry);

            return list;
        }

        #endregion

        static void Main(string[] args)
        {
            AddArrays(new List<int> { 9, 9, 1, 9 }, new List<int> { 1, 2, 1 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
