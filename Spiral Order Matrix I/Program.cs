namespace Spiral_Order_Matrix_I
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        /*
           Given a matrix of m * n elements (m rows, n columns), return all elements of the matrix in spiral order.

            Example:

            Given the following matrix:

            [
                [ 1, 2, 3 ],
                [ 4, 5, 6 ],
                [ 7, 8, 9 ]
            ]
            You should return

            [1, 2, 3, 6, 9, 8, 7, 4, 5]
        */

        public List<int> spiralOrder(List<List<int>> A)
        {
            int top = 0;
            int right = A[0].Count - 1;
            int bottom = A.Count - 1;
            int left = 0;
            int dir = 0; //Right is 0, Bottom is 1, Left is 2, Up is 3
            int i, j = 0;
            var result = new List<int>();
            while (top <= bottom && left <= right)
            {
                if(dir == 0)
                {
                    for (j = left; j <= right; j++)
                    {
                        result.Add(A[top][j]);
                    }
                    dir = 1;
                    top++;
                }
                else if (dir == 1)
                {
                    for (i = top; i <= bottom; i++)
                    {
                        result.Add(A[i][right]);
                    }
                    dir = 2;
                    right--;
                }
                else if (dir == 2)
                {
                    for (j = right; j >= left; j--)
                    {
                        result.Add(A[bottom][j]);
                    }
                    dir = 3;
                    bottom--;
                }
                else if (dir == 3)
                {
                    for (i = bottom; i >= top; i--)
                    {
                        result.Add(A[i][left]);
                    }
                    dir = 0;
                    left++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            var rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            var columns = int.Parse(Console.ReadLine());
            var list = new List<List<int>>();
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                var tempList = new List<int>();
                for (int j = 0; j < columns; j++)
                {
                    count++;
                    Console.WriteLine("Enter number {0}:\t", count);
                    var num = int.Parse(Console.ReadLine());
                    tempList.Add(num);
                }
                list.Add(tempList);
            }
            
            var result = new Program().spiralOrder(list);
            foreach (var item in result)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
