namespace Max_Distance
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int MaximumGap(List<int> A)
        {
            #region Solution 1 - O(N^2)
            //int jMinusI = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    for (int j = A.Count - 1; j>=0; j--)
            //    {
            //        if (A[i] <= A[j])
            //        {
            //            jMinusI = Math.Max(jMinusI, j - i);
            //        }
            //    }
            //}
            //return jMinusI;
            #endregion

            #region Solution 2 - Using Binary Search - O(nLogn)
            //// First create an array having maximum values from the end
            //int[] max = new int[A.Count+1];
            //for (int i = A.Count-1; i >=0; i--)
            //{
            //    max[i] = Math.Max(max[i+1], A[i]);
            //}
            //int result = 0;
            //int ans;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    int low = i + 1;
            //    int high = A.Count - 1;
            //    ans = i;
            //    while(low <= high)
            //    {
            //        int mid = (low + high) / 2;
            //        if (A[i] <= max[mid])
            //        {
            //            low = mid + 1;
            //            ans = Math.Max(ans, mid);
            //        }
            //        else
            //        {
            //            high = mid - 1;
            //        }
            //    }
            //    result = Math.Max(ans - i, result);
            //}
            //return result;
            #endregion

            #region Solution 3 - Using 2 arrays of space and time - O(n)
            //// Create maxR array having maximum values from right of A
            //int[] maxR = new int[A.Count];
            //maxR[A.Count - 1] = A[A.Count - 1];
            //int i;
            //for (i = A.Count - 2; i >= 0; i--)
            //{
            //    maxR[i] = Math.Max(maxR[i + 1], A[i]);
            //}

            //// Create minL array having minimum values from left of A
            //int[] minL = new int[A.Count];
            //minL[0] = A[0];
            //for (i = 1; i < A.Count; i++)
            //{
            //    minL[i] = Math.Min(minL[i - 1], A[i]);
            //}

            //i = 0; int j = 0;
            //int diff = -1;
            //while(i < A.Count && j < A.Count)
            //{
            //    if(minL[i] <= maxR[j])
            //    {
            //        diff = Math.Max(diff, j - i);
            //        j++;
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
            //return diff;
            #endregion

            #region Solution 4 - Using only 1 extra array of space and time - O(n)
            // Create maxR array having maximum values from right of A
            int[] maxR = new int[A.Count];
            maxR[A.Count - 1] = A[A.Count - 1];
            int i;
            for (i = A.Count - 2; i >= 0; i--)
            {
                maxR[i] = Math.Max(maxR[i + 1], A[i]);
            }

            i = 0; int j = 0;
            int diff = -1;
            while (i < A.Count && j < A.Count)
            {
                if (A[i] <= maxR[j])
                {
                    diff = Math.Max(diff, j - i);
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return diff;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaximumGap(new List<int> { 3, 5, 4, 2 }));
        }
    }
}
