namespace Maximum_Sum_Triplet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A)
        {
            #region Solution 1 -- O(n cube)
            //int result = 0;
            //for (int i = 0; i < A.Count - 2; i++)
            //{
            //    int sum = 0;
            //    sum += A[i];
            //    for (int j = i + 1; j < A.Count - 1; j++)
            //    {
            //        sum = A[i];
            //        if (A[j] == A.Max() || A[j] <= A[i]) continue;
            //        else sum += A[j];
            //        //if (sum == A[i]) return 0;
            //        for (int k = j + 1; k < A.Count; k++)
            //        {
            //            if (A[k] <= A[j]) continue;
            //            if (sum > A[i] + A[j]) sum = A[i] + A[j];
            //            sum += A[k];
            //            if (result < sum)
            //            {
            //                result = sum; sum = 0;
            //            }
            //        }
            //    }
            //}
            //return result;
            #endregion

            #region Solution 2 -- O(n square)
            //int result = 0;
            //for (int j = 1; j < A.Count - 1; j++)
            //{
            //    int max1 = 0, max2 = 0;
            //    for(int i = 0; i < j; i++)
            //    {
            //        if (A[i] < A[j]) max1 = Math.Max(max1, A[i]);
            //    }

            //    for (int k = j + 1; k < A.Count; k++)
            //    {
            //        if (max1 == 0) break;
            //        if (A[k] > A[j]) max2 = Math.Max(max2, A[k]);
            //    }

            //    result = max1 == 0 || max2 == 0 ? result : Math.Max(result, max1 + max2 + A[j]);
            //}
            //return result;
            #endregion

            #region Solution 3 -- o(nlogn)
            //var sufixMapGreater = new Dictionary<int, int>();
            //var localMaxGreater = A[^1];
            //for (int i = A.Count - 1; i > 0; i--)
            //{
            //    if (A[i] > localMaxGreater)
            //    {
            //        localMaxGreater = A[i];
            //    }
            //    sufixMapGreater.Add(i, localMaxGreater);
            //}

            //var sorted = new SortedList<int, int>();
            //sorted.Add(A[0], 0);

            //int? max = null;

            //for (int i = 1; i <= A.Count - 2; i++)
            //{
            //    var second = A[i];
            //    var third = sufixMapGreater[i];

            //    if (second >= third)
            //    {
            //        if (!sorted.ContainsKey(second))
            //        {
            //            sorted.Add(second, i);
            //        }
            //        continue;
            //    }

            //    int? firstCandidate = null;

            //    var left = 0;
            //    var right = sorted.Count - 1;
            //    while (left <= right)
            //    {
            //        var index = (left + right) / 2;

            //        if (sorted.Keys[index] >= second)
            //        {
            //            if (right == index)
            //                right--;
            //            else
            //            {
            //                right = index;
            //            }
            //        }
            //        else
            //        {
            //            if (!firstCandidate.HasValue)
            //            {
            //                firstCandidate = sorted.Keys[index];
            //            }
            //            else
            //            {
            //                firstCandidate = Math.Max(firstCandidate.Value, sorted.Keys[index]);
            //            }

            //            if (left == index)
            //            {
            //                left++;
            //            }
            //            else
            //            {
            //                left = index;
            //            }
            //        }
            //    }

            //    if (firstCandidate.HasValue)
            //    {
            //        if (!max.HasValue)
            //        {
            //            max = firstCandidate + second + third;
            //        }
            //        else
            //        {
            //            max = Math.Max(max.Value, firstCandidate.Value + second + third);
            //        }

            //    }

            //    if (!sorted.ContainsKey(second))
            //    {
            //        sorted.Add(second, i);
            //    }
            //}

            //if (max.HasValue)
            //{
            //    return max.Value;
            //}

            //return 0;
            #endregion

            #region Solution 4 -- O(nlogn) -- BEST
            int n = A.Count;

            // Initialize suffix-array
            int[] maxSuffArr = new int[n + 1];

            // Calculate suffix-array containing maximum
            // value for index i, i+1, i+2, ... n-1 in
            // arr[i]
            for (int i = n - 1; i >= 0; --i)
                maxSuffArr[i] = Math.Max(maxSuffArr[i+1], A[i]);

            int ans = 0;

            // Initialize set container
            SortedSet<int> lowValue = new SortedSet<int>();

            // Insert minimum value for first comparison
            // in the set
            lowValue.Add(A[0]);

            for (int i = 1; i < n - 1; ++i)
            {
                if (maxSuffArr[i + 1] > A[i])
                {
                    ans = Math.Max(ans, lowValue.GetViewBetween(0, A[i]).Max() +
                                   A[i] + maxSuffArr[i + 1]);

                    // Insert arr[i] in set<> for further
                    // processing
                    lowValue.Add(A[i]);
                }
            }
            return ans;
            #endregion // BEST
        }

        static void Main(string[] args)
        {
            Solve(new List<int> { 2, 5, 3, 1, 4, 9, 10 });
        }
    }
}
