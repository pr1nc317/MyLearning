namespace Rotated_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int FindMin(List<int> A)
        {
            if (A.Count == 1) return A[0];
            int pivot = BinarySearch(A);
            return A[pivot];
        }

        public static int BinarySearch(List<int> A)
        {
            int start = 0;
            int end = A.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (A[mid] > A[mid+1])
                {
                    return mid + 1;
                }
                else if (mid-1 >= 0 && A[mid - 1] > A[mid])
                {
                    return mid;
                }
                else if (A[start] > A[mid])
                {
                    end = mid;
                }
                else if (A[mid] > A[end])
                {
                    start = mid;
                }
                else if (A[start] < A[end])
                {
                    return start;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(FindMin(new List<int> { 15, 16, 17, 18, 19, 20, 21, 22, 23 }));
            Console.WriteLine(FindMin(new List<int> { 1 }));
        }
    }
}
