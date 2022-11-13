namespace Rotated_Sorted_Array_Search
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Search(List<int> A, int B)
        {
            int pivot = FindPivotPoint(A);
            int index = BinarySearch(A.GetRange(0, pivot), B);
            if (index >= 0) return index;
            else
            {
                index = BinarySearch(A.GetRange(pivot, A.Count - pivot), B);
                if (index >= 0)
                    return index + pivot;
            }
            return -1;
        }

        public static int FindPivotPoint(List<int> A)
        {
            int start = 0;
            int end = A.Count - 1;
            if (A[start] < A[end]) return 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (mid > 0 && mid <= A.Count - 1)
                {
                    if (A[mid] < A[mid - 1])
                    {
                        return mid;
                    }
                    else if (mid < A.Count - 1 && A[mid] > A[mid + 1])
                    {
                        return mid + 1;
                    }
                    else if (A[mid] > A[mid - 1])
                    {
                        if (A[start] > A[mid])
                        {
                            end = mid;
                        }
                        else start = mid;
                    }
                }
            }
            return 0;
        }

        public static int BinarySearch(List<int> A, int B)
        {
            int start = 0;
            int end = A.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (A[mid] == B)
                {
                    return mid;
                }
                else if (A[mid] > B) end = mid - 1;
                else start = mid + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new List<int> { 4, 5, 6, 7, 0, 1, 2, 3 }, 8));
            Console.WriteLine(Search(new List<int> { 5, 17, 100, 3 }, 6));
        }
    }
}