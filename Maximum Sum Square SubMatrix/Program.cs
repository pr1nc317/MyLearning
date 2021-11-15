namespace Maximum_Sum_Square_SubMatrix
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<List<int>> A, int B)
        {
            int maxSum = int.MinValue;
            int N = A.Count;
            int[,] arr = new int[N, N];

            // First, calculate column wise sum for the range B and store it in the first row, first column element itself (0,0)
            for (int j = 0; j < N; j++)
            {
                int sum = 0;
                for (int i = 0; i < B; i++)
                {
                    sum += A[i][j];
                }
                arr[0, j] = sum;

                // Second, calculate sum for other sub matrix as well by adding a next row element and removing a top row element
                for (int i = 1; i < N + 1 - B; i++)
                {
                    sum += A[i + B - 1][j] - A[i - 1][j];
                    arr[i, j] = sum;
                }
            }

            // Third, Repeat step 1 but this time we have to do it across rows by adding the sum of the first B elements in every row which will give us
            // the square matrix sum of size BxB
            for (int i = 0; i < N - B + 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < B; j++)
                {
                    sum += arr[i, j];
                }

                if (sum > maxSum)
                    maxSum = sum;

                // Fourth step is to repeat step 2 for rows in order to calculate sub matrix as well
                for (int j = 1; j < N + 1 - B; j++)
                {
                    sum += arr[i, j + B - 1] - arr[i, j - 1];

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }
            return maxSum;
        }

        static void Main(string[] args)
        {
            var res = Solve(new List<List<int>>
            {
                new List<int> { 1, 1, 1, 1, 1 },
                new List<int> { 2, 2, 2, 2, 2 },
                new List<int> { 3, 8, 6, 7, 3 },
                new List<int> { 4, 4, 4, 4, 4 },
                new List<int> { 5, 5, 5, 5, 5 }
            }, 3);
            Console.WriteLine(res);
        }
    }
}
