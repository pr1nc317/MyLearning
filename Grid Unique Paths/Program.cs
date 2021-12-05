namespace Grid_Unique_Paths
{
    using System;
    using System.Linq;

    class Program
    {
        public static int UniquePaths(int A, int B)
        {
            #region Solution 1 - using recursion
            //int[,] arr = new int[A, B];
            //for (int i = 0; i < A; i++)
            //{
            //    arr[i, 0] = 1;
            //}
            //for (int i = 0; i < B; i++)
            //{
            //    arr[0, i] = 1;
            //}
            //for (int i = 1; i < A; i++)
            //{
            //    for (int j = 1; j < B; j++)
            //    {
            //        arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
            //    }
            //}
            //return arr[A - 1, B - 1];
            #endregion

            #region Solution 2 - using Combinations
            /*
            Total number of moves in which we have to move down to reach the last row = m – 1 (m rows, since we are starting from (1, 1) that is not included)
            Total number of moves in which we have to move right to reach the last column = n – 1 (n column, since we are starting from (1, 1) that is not included)
            Down moves = (m – 1)
            Right moves = (n – 1)
            Total moves = Down moves + Right Moves = (m – 1) + (n – 1) 
            Now think moves as a string of ‘R’ and ‘D’ character where ‘R’ at any ith index will tell us to move ‘Right’ and ‘D’ will tell us to move ‘Down’
            Now think of how many unique strings (moves) we can make where in total there should be (n – 1 + m – 1) characters and there should be (m – 1) ‘D’ character and (n – 1) ‘R’ character? 
            Choosing positions of (n – 1) ‘R’ characters, results in automatic choosing of (m – 1) ‘D’ character positions 
            Number of ways to choose positions for (n – 1) ‘R’ character = Total positions C n – 1 = Total positions C m – 1 = (n – 1 + m – 1) != \frac {(n - 1 + m - 1)!} {(n - 1) ! (m - 1)!} 
            */
            int ans = 1;
            for (int i = B; i < A + B - 1; i++)
            {
                ans *= i;
                ans /= i - B + 1;
            }
            return ans;
            #endregion

        }

        static void Main(string[] args)
        {
            Console.WriteLine(UniquePaths(100, 1));
        }
    }
}
