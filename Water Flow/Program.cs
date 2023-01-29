namespace Water_Flow
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int[] xaxis = new int[] { 0, 1, 0, -1 };
        public static int[] yaxis = new int[] { 1, 0, -1, 0 };

        public class Pair
        {
            public int x; public int y;
            public Pair(int x, int y) { this.x = x; this.y = y; }
        }

        public static int Solve(List<List<int>> A)
        {
            int rows = A.Count;
            int cols = A[0].Count;

            // create 2 queues for blue and red ocean and 2 matrices for storing visited points
            Queue<Pair> q1 = new Queue<Pair>();
            Queue<Pair> q2 = new Queue<Pair>();
            int[,] vis1 = new int[rows, cols];
            int[,] vis2 = new int[rows, cols];

            // fill in the indexes for Q1 and Q2 of the sides which are touching the oceans
            for (int i = 0; i < cols; i++)
            {
                q1.Enqueue(new Pair(0, i));
                q2.Enqueue(new Pair(rows - 1, i));
            }
            for (int i = 0; i < rows - 1; i++)
            {
                q1.Enqueue(new Pair(i + 1, 0));
                q2.Enqueue(new Pair(i, cols - 1));
            }

            // BFS for Q1 and Q2
            BFS(A, q1, vis1, rows, cols);
            BFS(A, q2, vis2, rows, cols);

            int ans = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (vis1[i, j] == 1 && vis2[i, j] == 1)
                        ans++;
                }
            }
            return ans;
        }

        public static void BFS(List<List<int>> A, Queue<Pair> q, int[,] vis, int rows, int cols)
        {
            // run BFS
            while (q.Count > 0)
            {
                // pop and mark the node visited, then explore its adjacent nodes
                var deq = q.Dequeue();
                vis[deq.x, deq.y] = 1;
                for (int i = 0; i < 4; i++)
                {
                    var newX = deq.x + xaxis[i];
                    var newY = deq.y + yaxis[i];
                    if (IsSafe(newX, newY, rows, cols) && A[newX][newY] >= A[deq.x][deq.y] && vis[newX, newY] == 0)
                    {
                        vis[newX, newY] = 1;
                        q.Enqueue(new Pair(newX, newY));
                    }
                }
            }
        }

        public static bool IsSafe(int x, int y, int rows, int cols)
        {
            if (x < 0 || y < 0 || x >= rows || y >= cols)
                return false;
            return true;
        }

        static void Main(string[] args)
        {
            var list = new List<List<int>>()
            {
                new List<int> { 1, 2, 2, 3, 5 },
                new List<int> { 3, 2, 3, 4, 4 },
                new List<int> { 2, 4, 5, 3, 1 },
                new List<int> { 6, 7, 1, 4, 5 },
                new List<int> { 5, 1, 1, 2, 4 }
            };
            Console.WriteLine(Solve(list));
        }
    }
}
