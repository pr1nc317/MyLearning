namespace Spiral_Order_Matrix_II
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<List<int>> GenerateMatrix(int A)
        {
            var list = new List<List<int>>();
            for (int i = 0; i < A; i++)
            {
                list.Add(Enumerable.Repeat(0, A).ToList());
            }

            int top = 0;
            int right = A - 1;
            int bottom = A - 1;
            int left = 0;
            int dir = 0; //Right is 0, Bottom is 1, Left is 2, Up is 3
            int num = 1;

            while (top <= bottom && left <= right)
            {
                if (dir == 0)
                {
                    for (int j = left; j <= right; j++)
                    {
                        list[top][j] = num;
                        num++;
                    }
                    top++;
                    dir++;
                }
                if (dir == 1)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        list[i][right] = num;
                        num++;
                    }
                    right--;
                    dir++;
                }
                if (dir == 2)
                {
                    for (int j = right; j >= left; j--)
                    {
                        list[bottom][j] = num;
                        num++;
                    }
                    bottom--;
                    dir++;
                }
                if (dir == 3)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        list[i][left] = num;
                        num++;
                    }
                    left++;
                    dir = 0;
                }
            }

            return list;
        }

        static void Main(string[] args)
        {
            var list = GenerateMatrix(4);
            for (int i = 0; i < list.Count; i++)
            {
                list[i].ForEach(x => Console.Write(x + " "));
                Console.WriteLine();
            }
        }
    }
}
