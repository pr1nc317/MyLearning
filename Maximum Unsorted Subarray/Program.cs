namespace Maximum_Unsorted_Subarray
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> SubUnsort(List<int> A)
        {
            #region Solution 1 - O(n) with 2 extra arrays
            //int i = 0;

            //// Create MinR array from right end of A
            //int[] minR = new int[A.Count];
            //minR[A.Count - 1] = A[A.Count - 1];
            //for (int k = A.Count - 2; k >= 0; k--)
            //{
            //    minR[k] = Math.Min(minR[k + 1], A[k]);
            //}

            //// Create maxL array from left end of A
            //int[] maxL = new int[A.Count];
            //maxL[0] = A[0];
            //for (int k = 1; k < A.Count; k++)
            //{
            //    maxL[k] = Math.Max(maxL[k - 1], A[k]);
            //}

            //while (i < A.Count - 1)
            //{
            //    if (A[i] > minR[i])
            //    {
            //        break;
            //    }
            //    i++;
            //}
            //if (i == A.Count - 1) return new List<int> { -1 };

            //int j = A.Count - 1;
            //while (j >= 0)
            //{
            //    if (A[j] < A[i]) 
            //    {
            //        break;
            //    }
            //    else if (minR[j] < maxL[j])
            //    {
            //        break;
            //    }
            //    j--;
            //}
            //return new List<int> { i, j };
            #endregion

            #region Solution 2 - O(n) without any extra space
            int s, e;
            // Find first number from left which is greater than the immediate right number
            for (s = 0; s < A.Count - 1; s++)
            {
                if (A[s] > A[s + 1])
                {
                    break;
                }
            }

            if (s == A.Count - 1) return new List<int> { -1 };

            // Find first number from right which is lesser than the immediate left number
            for (e = A.Count - 1; e >= 0; e--)
            {
                if (A[e] < A[e - 1])
                {
                    break;
                }
            }

            int max = A[s], min = A[s];

            for(int i = s + 1; i < e; i++)
            {
                if (A[i] > A[s])
                    max = A[i];
                if (A[i] < A[s])
                    min = A[i];
            }

            for (int i = 0; i < s; i++)
            {
                if (A[i] >= min)
                {
                    s = i; break;
                }
            }

            for (int i = A.Count - 1; i > e; i--)
            {
                if (A[i] <= max)
                {
                    e = i; break;
                }
            }

            return new List<int> { s, e };
            #endregion
        }

        static void Main(string[] args)
        {
            SubUnsort(new List<int> { 3, 8, 14, 12, 14, 14, 15, 19, 17, 19, 19 }).ForEach(x => Console.Write(x + " "));
        }
    }
}