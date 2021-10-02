using System;

namespace BirthdayCakeCandles_HackerRank
{
    class Program
    {
        static int BirthdayCakeCandles(int[] ar)
        {
            int res = 0;
            Array.Sort(ar);
            foreach (var item in ar)
            {
                if (item == ar[ar.Length - 1])
                {
                    res++;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int a = BirthdayCakeCandles(arr);
        }
    }
}
