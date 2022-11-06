namespace Allocate_Books
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Books(List<int> A, int B)
        {
            if (B > A.Count) return -1;
            int start = int.MinValue;
            int end = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > start) start = A[i];
                end += A[i];
            }
            int result = 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (IsFfeasible(A, B, mid))
                {
                    result = mid;
                    end = mid - 1;
                }
                else start = mid + 1;
            }
            return result;
        }

        public static bool IsFfeasible(List<int> A, int students, int mid)
        {
            int st = 1;
            int curr = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (curr + A[i] <= mid)
                    curr += A[i];
                else
                {
                    curr = A[i];
                    st++;
                }
                if (st > students) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Books(new List<int> { 12, 34, 67, 90 }, 2));
        }
    }
}
