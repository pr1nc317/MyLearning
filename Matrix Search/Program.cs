namespace Matrix_Search
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int SearchMatrix(List<List<int>> A, int B)
        {
            int rows = A.Count;
            int cols = A[0].Count;
            int start = 0;
            int end = rows * cols - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int r = mid / cols;
                int c = mid % cols;
                //if (c > 0)
                //{
                //    c--;
                //}
                //else if (c == 0 && r > 0)
                //{
                //    c = cols - 1;
                //    r--;
                //}
                if (A[r][c] == B) return 1;
                else if (A[r][c] > B) end = mid - 1;
                else start = mid + 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SearchMatrix(new List<List<int>> {
                new List<int> { 1, 3, 5, 7 },
                new List<int> { 10, 11, 16, 20 },
                new List<int> { 23, 30, 34, 50 }
            }, 10));
            Console.WriteLine(SearchMatrix(new List<List<int>> {
                new List<int> { 5, 17, 100, 111 },
                new List<int> { 119, 120, 127, 131 }
            }, 3));
        }
    }
}