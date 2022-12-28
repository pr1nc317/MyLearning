namespace Min_XOR_value
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int FindMinXor(List<int> A)
        {
            /*
             * Two ways to solve:
             * 1. Two loops - O(N^2)
             * 2. Sort the list, then xor every consecutive pair - O(NLogN + N) = O(NLogN) : https://www.youtube.com/watch?v=OZ2jghS0t24
             */

            #region Approach 2
            var minXor = int.MaxValue;
            A.Sort();
            for (int i = 0; i < A.Count - 1; i++)
            {
                var temp = A[i] ^ A[i + 1];
                if (temp < minXor)
                    minXor = temp;
            }
            return minXor;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindMinXor(new List<int> { 0, 7, 5, 2 }));
        }
    }
}
