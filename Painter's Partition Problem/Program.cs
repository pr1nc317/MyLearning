namespace Painter_s_Partition_Problem
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Paint(int A, int B, List<int> C)
        {
            long start = int.MinValue;
            long end = 0;
            int mod = 10000003;
            foreach (var item in C)
            {
                if (item > start)
                {
                    start = item;
                }
                end += item;
            }
            if (A > C.Count) return (int) start * B;
            long result = 0;
            int res = 0;
            while (start <= end)
            {
                long mid = (start + end) / 2;
                if (IsFeasible(A, C, mid))
                {
                    result = ((mid % mod) * (B % mod)) % mod;
                    res = (int)result;
                    end = mid - 1;
                }
                else start = mid + 1; 
            }
            return res;
        }

        public static bool IsFeasible(int totalPainters, List<int> boardList, long mid)
        {
            int painters = 1;
            int currBoardLen = 0;
            for (int i = 0; i < boardList.Count; i++)
            {
                if (currBoardLen + boardList[i] <= mid)
                    currBoardLen += boardList[i];
                else
                {
                    painters++;
                    currBoardLen = boardList[i];
                }
                if (painters > totalPainters) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Paint(2, 5, new List<int> { 1, 10 }));
            //Console.WriteLine(Paint(10, 1, new List<int> { 1, 8, 11, 3 }));
            Console.WriteLine(Paint(1, 1000000, new List<int> { 1000000, 1000000 }));
        }
    }
}
