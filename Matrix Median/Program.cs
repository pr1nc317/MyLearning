namespace Matrix_Median
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int FindMedian(List<List<int>> A)
        {
            int min = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i][0] < min) min = A[i][0];
            }
            int max = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i][A[i].Count - 1] > max) max = A[i][A[i].Count - 1];
            }

            int rows = A.Count;
            int cols = A[0].Count;
            int desired = (rows * cols + 1) / 2;

            while (min < max)
            {
                int mid = (min + max) / 2;
                int place = 0;
                int get;
                for (int i = 0; i < rows; i++)
                {
                    get = Array.BinarySearch(GetRow(A, i), mid);
                    if (get < 0)
                    {
                        get = Math.Abs(get) - 1;
                    }
                    else
                    {
                        while (get < GetRow(A,i).Length && A[i][get] == mid)
                        {
                            get += 1;
                        }
                    }
                    place += get;
                }
                if (place < desired) min = mid + 1;
                else max = mid;
            }
            return min;
        }

        public static int[] GetRow(List<List<int>> A, int row)
        {
            var arr = new int[A[row].Count];
            for (int i = 0; i < A[row].Count; i++)
            {
                arr[i] = A[row][i];
            }
            return arr;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(FindMedian(new List<List<int>> { 
            //    new List<int> { 1, 3, 5},
            //    new List<int> { 2, 6, 9},
            //    new List<int> { 3, 6, 9}
            //}));
            Console.WriteLine(FindMedian(new List<List<int>> {
                new List<int> { 5, 17, 100 }
            }));
        }
    }
}
