namespace Capture_Regions_On_Board
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int[] xAxis = new int[] { 0, 1, 0, -1 };
        public static int[] yAxis = new int[] { 1, 0, -1, 0 };

        public class Pair
        {
            public int row; public int col;
            public Pair(int row, int col) { this.row= row; this.col = col; }
        }

        public static void Solve(List<List<char>> A)
        {
            // replace 'O' with '-'
            int rows = A.Count;
            int cols = A[0].Count;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i][j] == 'O')
                        A[i][j] = '-';
                }
            }

            // call FloodFill algo from 4 edges to replace '-' with 'O' for only adjacent nodes
            // for top edge
            for (int i = 0, j = 0; j < cols; j++)
            {
                FloodFill(A, i, j, '-', 'O');
            }
            // for left edge
            for (int i = 0, j = 0; i < rows; i++)
            {
                FloodFill(A, i, j, '-', 'O');
            }
            // for bottom edge
            for (int i = rows - 1, j = 0; j < cols; j++)
            {
                FloodFill(A, i, j, '-', 'O');
            }
            // for right edge
            for (int i = 0, j = cols - 1; i < rows; i++)
            {
                FloodFill(A, i, j, '-', 'O');
            }

            // Now replace the remaining '-' with 'X'
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i][j] == '-')
                        A[i][j] = 'X';
                }
            }
        }

        public static void FloodFill(List<List<char>> A, int x, int y, char oldChar, char newChar)
        {
            if (A[x][y] != oldChar)
                return;
            int rows = A.Count;
            int cols = A[0].Count;
            Queue<Pair> queue = new Queue<Pair>();
            queue.Enqueue(new Pair(x, y));
            while (queue.Count > 0)
            {
                var deq = queue.Dequeue();
                A[deq.row][deq.col] = 'O';
                for (int i = 0; i < 4; i++)
                {
                    var newX = deq.row + xAxis[i];
                    var newY = deq.col + yAxis[i];
                    if (IsValid(newX, newY, rows, cols) && A[newX][newY] == oldChar)
                    {
                        queue.Enqueue(new Pair(newX, newY));
                    }
                }
            }
        }

        public static bool IsValid(int x, int y, int row, int col)
        {
            if (x < 0 || y < 0 || x >= row || y >= col) return false;
            return true;
        }

        static void Main(string[] args)
        {
            var list = new List<List<char>>()
            {
                new List<char> { 'X', 'O', 'O', 'X' },
                new List<char> { 'X', 'O', 'X', 'X' },
                new List<char> { 'X', 'X', 'O', 'X' },
                new List<char> { 'X', 'O', 'X', 'X' }
            };
            Solve(list);
            list.ForEach(x => { x.ForEach(y => Console.Write(y + " ")); Console.WriteLine(); });
        }
    }
}
