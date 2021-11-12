namespace Find_Permutation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int[] FindPermutation(string A, int B)
        {
            int[] arr = new int[B];
            int start = 1;
            int end = B;
            int i = 0;
            for (i = 0; i < A.Length; i++)
            {
                if(A[i] == 'I')
                {
                    arr[i] = start++;
                }
                else
                {
                    arr[i] = end--;
                }
            }
            arr[i] = start;
            return arr;
        }

        static void Main(string[] args)
        {
            var ans = FindPermutation("IDI", 4);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
