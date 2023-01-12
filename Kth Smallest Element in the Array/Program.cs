namespace Kth_Smallest_Element_in_the_Array
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Kthsmallest(List<int> A, int B)
        {
            #region Approach 1 - Using Quick Sort Technique
            //return QuickSort(A, 0, A.Count - 1, B);
            #endregion

            #region Approach 2 - Using Binary Search
            // find max and min
            int low = int.MaxValue;
            int high = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                low = Math.Min(low, A[i]);
                high = Math.Max(high, A[i]);
            }

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (Count(A, mid) < B)
                    low = mid + 1;
                else high = mid;
            }
            return low;
            #endregion
        }

        public static int Count(List<int> A, int mid)
        {
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] <= mid)
                    count++;
            }
            return count;
        }

        public static int QuickSort(List<int> A, int left, int right, int B)
        {
            int pos = PartitionForQuickSort(A, left, right);
            if (pos - left == B - 1)
                return A[pos];
            if (pos - left > B - 1)
                return QuickSort(A, left, pos - 1, B);
            else return QuickSort(A, pos + 1, right, B - (pos - left) - 1);
        }

        public static int PartitionForQuickSort(List<int> A, int left, int right)
        {
            int pivot = A[right];
            int i = left - 1; int j = left; ; int temp = 0;
            for (; j <= right - 1; j++)
            {
                if (A[j] <= pivot)
                {
                    i++;
                    temp = A[i]; A[i] = A[j]; A[j] = temp;
                }
            }
            temp = A[i + 1]; A[i + 1] = A[right]; A[right] = temp;
            return i + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Kthsmallest(new List<int> { 2, 1, 4, 3, 2 }, 3));
            Console.WriteLine(Kthsmallest(new List<int> { 1, 2 }, 1));
        }
    }
}
