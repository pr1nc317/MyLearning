namespace Different_Bits_Sum_Pairwise
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int CntBits(List<int> A)
        {
            #region Approach 1 - O(n^2) - take each pair, find out XOR and then count set bits
            //int count = 0;
            //for (int i = 0; i < A.Count - 1; i++)
            //{
            //    for (int j = i + 1; j < A.Count; j++)
            //    {
            //        count += CountOnes(A[i] ^ A[j]) * 2;
            //    }
            //}
            //return count;
            #endregion

            #region Approach 2 - O(n)
            /* 
             * Every number is formed by 32 bits. if we can calculate for each of the 32 bits which bit is set, then we can easily
             * calculate how many bits are not set. Lets say n bits are set for the i-th bit, then A.Count - n bits are not set
             * and so the result will be n * (A.Count - n) * 2. We need to do this for each of the 32 bits.
             */
            long setBitCount;
            long count = 0;
            int mod = 1000000007;
            for (int i = 0; i < 32; i++)
            {
                setBitCount = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if ((A[j] & (1 << i)) != 0)
                    {
                        setBitCount++;
                    }
                }
                count += ((setBitCount * (A.Count - setBitCount)) % mod * 2 % mod);
            }
            return (int)(count % mod);
            #endregion
        }

        public static int CountOnes(int a)
        {
            int count = 0;
            while (a != 0)
            {
                a &= a - 1;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CntBits(new List<int> { 1, 3, 5 }));
        }
    }
}
