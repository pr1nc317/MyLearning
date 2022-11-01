namespace Search_for_a_Range
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> SearchRange(List<int> A, int B)
        {
            int startInd = BinarySearchFirstIndex(A, B);
            int lastInd = BinarySearchLastIndex(A, B);
            return new List<int> { startInd, lastInd };
        }

        public static int BinarySearchFirstIndex(List<int> A, int B)
        {
            int start = 0;
            int end = A.Count - 1;
            if (A[0] == B) return 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (mid > 0)
                {
                    if (A[mid] == B & A[mid - 1] != B) return mid;
                }
                if (A[mid] >= B)
                {
                    end = mid - 1;
                }
                else if (A[mid] < B)
                {
                    if (A[mid + 1] == B) return mid + 1;
                    else start = mid + 1;
                }
            }
            return -1;
        }

        public static int BinarySearchLastIndex(List<int> A, int B)
        {
            int start = 0;
            int end = A.Count - 1;
            if (A[A.Count - 1] == B) return A.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (mid < A.Count - 1)
                {
                    if (A[mid] == B & A[mid + 1] != B) return mid;
                }
                if (A[mid] > B)
                {
                    if (mid > 0)
                    {
                        if (A[mid - 1] == B) return mid - 1;
                    }
                    end = mid - 1;
                }
                else if (A[mid] <= B)
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            //SearchRange(new List<int> { 5, 17, 100, 111 }, 3).ForEach(x => Console.WriteLine(x + " "));
            SearchRange(new List<int> { 5, 7, 7, 8, 8, 8, 8, 10 }, 8).ForEach(x => Console.WriteLine(x + " "));
        }
    }
}