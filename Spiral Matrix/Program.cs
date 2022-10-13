namespace Spiral_Matrix
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<List<int>> Solve(List<int> A, int B, int C)
        {
            List<List<int>> ans = new List<List<int>>();
            int i; int j;
            for (i = 0; i < B; i++)
            {
                var temp = new List<int>();
                for (j = 0; j < C; j++)
                {
                    temp.Add(0);
                }
                ans.Add(temp);
            }
            int top = 0; int left = 0; int right = C - 1; int bottom = B - 1;
            string dir = "R"; i = 0; j = 0;
            for (int k = 0; k < A.Count; k++)
            {
                if (dir == "R")
                {
                    i = top;
                    if (j <= right)
                    {
                        ans[i][j] = A[k];
                    }
                    if (j == right)
                    {
                        dir = "B";
                        top++;
                        i = top;
                        continue;
                    }
                    j++;
                    continue;
                }
                if (dir == "B")
                {
                    j = right;
                    if (i <= bottom)
                    {
                        ans[i][j] = A[k];
                    }
                    if (i == bottom)
                    {
                        dir = "L";
                        right--;
                        j = right;
                        continue;
                    }
                    i++;
                    continue;
                }
                if (dir == "L")
                {
                    i = bottom;
                    if (j >= left)
                    {
                        ans[i][j] = A[k];
                    }
                    if (j == left)
                    {
                        dir = "U";
                        bottom--;
                        i = bottom;
                        continue;
                    }
                    j--;
                    continue;
                }
                if (dir == "U")
                {
                    j = left;
                    if (i >= top)
                    {
                        ans[i][j] = A[k];
                    }
                    if (i == top)
                    {
                        dir = "R";
                        left++;
                        j = left;
                        continue;
                    }
                    i--;
                    continue;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int B = 4;
            int C = 5;
            var ans = Solve(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, B, C);
            for (int i = 0; i < B; i++)
            {
                var temp = new List<int>();
                for (int j = 0; j < C; j++)
                {
                    Console.Write(ans[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
