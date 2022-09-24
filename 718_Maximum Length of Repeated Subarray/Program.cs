namespace _718_Maximum_Length_of_Repeated_Subarray
{
    using System;

    class Program
    {
        static int FindLength(int[] nums1, int[] nums2)
        {
            #region DP approach O(m*n) space and time
            //int maxLength = 0;
            //int[,] dp = new int[nums1.Length + 1, nums2.Length + 1];
            //// initialize whole dp table as 0
            //for (int i = 0; i <= nums1.Length; i++)
            //{
            //    for (int j = 0; j <= nums2.Length; j++)
            //    {
            //        dp[i, j] = 0;
            //    }
            //}
            //// traverse bottom up and if nums1[i]==nums2[j], then dp[i,j] = dp[i+1,j+1]
            //for (int i = nums1.Length - 1; i >= 0; i--)
            //{
            //    for (int j = nums2.Length - 1; j >= 0; j--)
            //    {
            //        if (nums1[i] == nums2[j])
            //        {
            //            dp[i, j] = dp[i + 1, j + 1] + 1;
            //            if (maxLength < dp[i,j])
            //            {
            //                maxLength = dp[i, j];
            //            }
            //        }
            //    }
            //}
            //return maxLength;
            #endregion

            #region Sliding Window Algorithm
            int ans = 0;
            for (int i = 0; i < nums1.Length + nums2.Length - 1; i++)
            {
                int astart = Math.Max(0, (nums1.Length - 1) - i);
                int bstart = Math.Max(0, i - (nums1.Length - 1));
                int consecutiveMatchingEle = 0;
                for (int aIdx = astart, bIdx = bstart; aIdx < nums1.Length && bIdx < nums2.Length; aIdx++, bIdx++)
                {
                    consecutiveMatchingEle = nums1[aIdx] == nums2[bIdx] ? consecutiveMatchingEle + 1 : 0;
                    ans = ans < consecutiveMatchingEle ? consecutiveMatchingEle : ans;
                }
            }
            return ans;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindLength(new int[] { 1, 2, 3, 2, 1 }, new int[] { 3, 2, 1, 4, 7 }));
            Console.WriteLine(FindLength(new int[] { 1, 2, 3, 2, 2, 1, 4, 0, 7 }, new int[] { 3, 2, 1, 4, 0, 7 }));
            Console.WriteLine(FindLength(new int[] { 70, 39, 25, 40, 7 }, new int[] { 52, 20, 67, 5, 31 }));
        }
    }
}
