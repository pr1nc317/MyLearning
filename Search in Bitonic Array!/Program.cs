namespace Search_in_Bitonic_Array_
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            int pivot = FindPivotUsingBinarySearch(A);
            var tempList = A.GetRange(0, pivot + 1);
            var ans = BinarySearchAscList(tempList, B);
            if (ans != -1) return ans;
            tempList = A.GetRange(pivot + 1, A.Count - pivot - 1);
            ans = BinarySearchDescList(tempList, B);
            return ans == -1 ? ans : ans + 1 + pivot;
        }

        public static int FindPivotUsingBinarySearch(List<int> A)
        {
            int start = 0;
            int end = A.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (A[mid] > A[mid + 1])
                {
                    return mid;
                }
                else if (A[mid] < A[mid - 1])
                {
                    return mid - 1;
                }
                else if (A[start] < A[mid])
                {
                    start = mid;
                }
                else if (A[mid] > A[end])
                {
                    end = mid;
                }
            }
            return 0;
        }

        public static int BinarySearchAscList(List<int> A, int B)
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
                else if (A[mid] < B)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }

        public static int BinarySearchDescList(List<int> A, int B)
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
                else if (A[mid] > B)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 5, 6, 17, 4, 3 }, 4));
        }
    }
}
