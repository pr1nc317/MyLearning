namespace Single_Number_II
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int SingleNumber(List<int> A)
        {
            /* 4 ways to solve
             * 1. Use Dictionary to keep a count of every number. Return whose value is 1 at the end. O(NLogN) time and O(N) space
             * 2. Sort the input list, then start from 1st index and verify if i-1 == i & i == i + 1, there will be 2 boundary cases if the
             * answer is at the beginning or at the end of the list after sort operation, so we need to handle that
             * accordingly. O(NLogN + N) time
             * 3. Loop from 0 to 31 since every integer is having 32 bit, use shift operation on 1 and take 
             * bitwise AND (&) for each i. O(32*N) time
             * 4. Use Bit Manipulation - keep track of numbers who are repeated once in 'ones' variable and who are repeated twice in 'twos' variable.
             * Initialize both the variables with 0. Loop through the list - take 'ones' value and XOR with the current number of the list.
             * Then do AND with the 1's complement of the value stored in twos variable. Assign the result to ones variable. Similarly calculate
             * twos variable values for each iteration. O(N) time
             */
            #region Approach 3
            int ans = 0;
            for (int i = 0; i < 32; i++)
            {
                int count = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if ((1 << i & A[j]) != 0)
                        count++;
                }
                if (count % 3 != 0)
                {
                    ans |= 1 << i;
                }
            }
            return ans;
            #endregion

            #region Approach 4
            //int ones = 0; int twos = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    ones ^= A[i] & (~twos);
            //    twos ^= A[i] & (~ones);
            //}
            //return ones;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new List<int> { 1, 1, 3, 1, 2, 2, 2 }));
        }
    }
}
