namespace Sorted_Insert_Position
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int SearchInsert(List<int> a, int b)
        {
            int start = 0;
            int end = a.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (a[mid] == b) return mid;
                else if (a[mid] < b)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return end + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsert(new List<int> { 1, 3, 5, 6 }, 6));
            Console.WriteLine(SearchInsert(new List<int> { 1, 3, 5, 6 }, 0));
        }
    }
}
