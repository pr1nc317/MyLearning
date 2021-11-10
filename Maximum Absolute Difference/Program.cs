namespace Maximum_Absolute_Difference
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int MaxArr(List<int> A)
        {
            #region Solution 1 - O(N sqaure)
            //int currSum, maxSum = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    for (int j = i; j < A.Count; j++)
            //    {
            //        currSum = Math.Abs(A[i] - A[j]) + Math.Abs(i - j);
            //        if (currSum > maxSum) maxSum = currSum;
            //    }
            //}
            //return maxSum;
            #endregion

            #region Solution 2 - O(N)
            /*
            |A[i] - A[j]| + |i - j| can be rewritten as following:

            1. if A[i] > A[j] and i > j, then |A[i] - A[j]| + |i - j| becomes (A[i] - A[j]) + (i - j) which can be written as (A[i] + i) - (A[j] + j)
            2. if A[i] < A[j] and i < j, then |A[i] - A[j]| + |i - j| becomes -(A[i] - A[j]) - (i - j) which can be written as -(A[i] + i) + (A[j] + j)
            3. if A[i] > A[j] and i < j, then |A[i] - A[j]| + |i - j| becomes (A[i] - A[j]) - (i - j) which can be written as (A[i] - i) - (A[j] - j)
            4. if A[i] < A[j] and i > j, then |A[i] - A[j]| + |i - j| becomes -(A[i] - A[j]) + (i - j) which can be written as -(A[i] - i) + (A[j] - j)

            Step 1 and 2 are similar and Step 3 and 4 are similar (just sign difference), so we can go ahead with 1 out of those pairs, 
            lets go ahead with calculating step 1 and step 4

            A[i] + i is termed as Max1, A[j] + j as Min1 and A[i] - i as Max2, A[j] - j as Min2
            */

            int Max1 = int.MinValue, Max2 = int.MinValue, Min1 = int.MaxValue, Min2 = int.MaxValue;
            
            for (int i = 0; i < A.Count; i++)
            {
                Max1 = Math.Max(Max1, A[i] + i);
                Min1 = Math.Min(Min1, A[i] + i);

                Max2 = Math.Max(Max2, A[i] - i);
                Min2 = Math.Min(Min2, A[i] - i);
            }
            return Math.Max(Max1 - Min1, Max2 - Min2);
            #endregion
        }

        static void Main(string[] args)
        {
            MaxArr(new List<int> { -98, -5, 37, -97, 38, 22, 70, 42, 61, 84 });
        }
    }
}
