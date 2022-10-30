namespace Smaller_or_equal_elements
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            if (B >= A[A.Count - 1]) return A.Count;
            if (B < A[0]) return 0;
            return BinarySearch(A, B);
        }

        public static int BinarySearch(List<int> A, int B)
        {
            // need to find an index which has a value greater than B and all values before that index should be less than equal to B
            int start = 0;
            int end = A.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (A[mid] <= B)
                {
                    if (A[mid + 1] > B)
                        return mid + 1;
                    start = mid;
                }
                else if (A[mid] > B)
                {
                    end = mid;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1, 1, 1, 1, 1 }, 1));
        }
    }
}
