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
            int desired = ((rows * cols) / 2) + 1;

            while (min < max)
            {
                int mid = (min + max) / 2;
                int place = 0;
                int get;
                for (int i = 0; i < rows; i++)
                {
                    #region Method 1 to calculate count of elements <= mid
                    //get = Array.BinarySearch(GetRow(A, i), mid);
                    //if (get < 0)
                    //{
                    //    get = Math.Abs(get) - 1;
                    //}
                    //else
                    //{
                    //    while (get < GetRow(A,i).Length && A[i][get] == mid)
                    //    {
                    //        get += 1;
                    //    }
                    //}
                    #endregion

                    #region Method 2 to calculate count of elements <= mid
                    var arr = GetRow(A, i);
                    get = CountOfEleLessThanEqualToMid(arr, mid);
                    #endregion
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

        public static int CountOfEleLessThanEqualToMid(int[] A, int num)
        {
            int start = 0;
            int end = A.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (A[mid] == num)
                {
                    if (mid < A.Length - 1)
                        if (A[mid + 1] > num) return mid + 1;
                        else start = mid + 1;
                    else return A.Length;
                }
                else if (A[mid] < num)
                    start = mid + 1;
                else if (A[mid] > num)
                    if (mid > 0)
                        if (A[mid - 1] == num) return mid;
                        else end = mid - 1;
                    else return 0;
            }
            return start;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindMedian(new List<List<int>> {
                new List<int> { 1, 3, 5},
                new List<int> { 2, 6, 9},
                new List<int> { 3, 6, 9}
            }));
            Console.WriteLine(FindMedian(new List<List<int>> {
                new List<int> { 5, 17, 100 }
            }));
            //Console.WriteLine(CountOfEleLessThanEqualToMid(new int[] { 1,2,3,4,6,7,8,9,10}, 0));
        }
    }
}
