﻿namespace Pick_from_both_sides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            var resultArray = new int[2 * B];
            int result = Int32.MinValue;
            if (B == A.Count) return A.Sum();
            for (int i = 0; i < 2 * B; i++)
            {
                if (i < B)
                {
                    resultArray[i] = A[i];
                }
                else resultArray[i] = A[A.Count - 2 * B + i];
            }
            for (int i = 0, j = 0, combination = 0; i < 2 * B; i++, combination++)
            {
                if (combination > B) break;
                if (i >= B)
                {
                    j = B - i;
                }
                else j = B + i;
                int count = 0;
                int sum = 0;
                for (int k = j; count < B; k++, count++)
                {
                    if (k >= 2 * B)
                        k -= 2 * B;
                    sum += resultArray[k];
                }
                if (sum > result)
                    result = sum;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Solve(new List<int> { -969, -948, 350, 150, -59, 724, 966, 430, 107, -809, -993, 337, 457, -713, 753, -617, -55, -91, -791, 758, -779, -412, -578, -54, 506, 30, -587, 168, -100, -409, -238, 655, 410, -641, 624, -463, 548, -517, 595, -959, 602, -650, -709, -164, 374, 20, -404, -979, 348, 199, 668, -516, -719, -266, -947, 999, -582, 938, -100, 788, -873, -533, 728, -107, -352, -517, 807, -579, -690, -383, -187, 514, -691, 616, -65, 451, -400, 249, -481, 556, -202, -697, -776, 8, 844, -391, -11, -298, 195, -515, 93, -657, -477, 587 }, 81);
        }
    }
}
