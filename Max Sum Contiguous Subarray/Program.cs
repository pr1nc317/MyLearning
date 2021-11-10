namespace Max_Sum_Contiguous_Subarray
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int MaxSubArray(List<int> A)
        {
            #region Solution 1 - Kadane's Algorithm O(N)
            int currSum = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                currSum += A[i];
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
                if (currSum < 0)
                {
                    currSum = 0;
                }
            }
            return maxSum;
            #endregion

            #region SOlution 2 - nested loops O(N square)
            //int maxSum = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    int currSum = 0;
            //    for (int j = i; j < A.Count; j++)
            //    {
            //        currSum += A[j];
            //        if (currSum > maxSum) maxSum = currSum;
            //    }                
            //}
            //return maxSum;
            #endregion
        }

        static void Main(string[] args)
        {
            MaxSubArray(new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        }
    }
}
