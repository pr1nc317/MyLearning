namespace Count_Element_Occurence
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int FindCount(List<int> A, int B)
        {
            int startIndex = BinarySearch(A, B, true);
            int lastIndex = BinarySearch(A, B, false);
            if (startIndex == -1 && lastIndex == -1) return 0;
            else return lastIndex - startIndex + 1;
        }

        public static int BinarySearch(List<int> A, int B, bool flag)
        {
            int start = 0;
            int end = A.Count - 1;
            int index = -1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (A[mid] == B)
                {
                    index = mid;
                    if (flag)
                    {
                        end = mid - 1;
                        if (end < 0 || A[end] < B) return index;
                    }
                    else
                    {
                        start = mid + 1;
                        if (start > A.Count - 1 || A[start] > B) return index;
                    }
                }
                else if (A[mid] < B)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindCount(new List<int> { 5, 5, 5, 7, 7, 8, 8, 10, 10, 10 }, 5));
        }
    }
}
