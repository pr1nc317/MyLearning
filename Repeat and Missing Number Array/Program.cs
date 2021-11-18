namespace Repeat_and_Missing_Number_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Solution
    {
        public static bool DetectIfCountGreaterThanOne(this List<int> A, int x)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (x == A[i])
                    count++;
                if (count > 1)
                    return true;
            }
            return false;
        }

        public static List<int> RepeatedNumber(List<int> A)
        {
            #region Solution 1 - Using extension methods - O(n^2) time and constant space
            //var list = new List<int>();
            //int x = 0, y = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (x == 0)
            //    {
            //        if (A.DetectIfCountGreaterThanOne(A[i]))
            //        {
            //            x = A[i];
            //        }
            //    }
            //    if (y == 0)
            //    {
            //        if (!A.Contains(i+1))
            //        {
            //            y = i + 1;
            //        }
            //    }
            //}
            //list.Add(x); list.Add(y);
            //return list;
            #endregion

            #region Solution 2 - Use elements as Index and mark the visited places - O(n) time and constant space
            int repeatedNum = 0, missingNum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int absVal = Math.Abs(A[i]);
                if (A[absVal - 1] > 0)
                    A[absVal - 1] = -A[absVal - 1];
                else if (A[absVal - 1] < 0)
                    repeatedNum = absVal;
            }

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > 0) missingNum = i + 1;
            }
            return new List<int> { repeatedNum, missingNum };
            #endregion
        }

        static void Main(string[] args)
        {
            RepeatedNumber(new List<int> { 3, 1, 2, 5, 5, 6 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
