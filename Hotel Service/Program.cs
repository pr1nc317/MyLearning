namespace Hotel_Service
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public class Matrix
        {
            public int row;
            public int col;
            public Matrix(int i, int j) { row = i; col = j; }
        }

        public class MatrixWithDistance
        {
            public int row;
            public int col;
            public int distance;
            public MatrixWithDistance(int i, int j, int dist) { row = i; col = j; distance = dist; }
        }

        public static List<int> NearestHotel(List<List<int>> A, List<List<int>> B)
        {
            #region Approach 1 - O(N^2 * M^2)
            //Queue<Matrix> q = new Queue<Matrix>();

            //// Traverse the complete matrix
            //for (int i = 0; i < A.Count; i++)
            //{
            //    for (int j = 0; j < A[0].Count; j++)
            //    {
            //        // If A[i][j] == 1, add the indices to the queue
            //        if (A[i][j] == 1)
            //            q.Enqueue(new Matrix(i, j));
            //    }
            //}

            //// For each entry in given list B, find the minimum distance of that cell from the nearest 1 by traversing the queue for each cell of B
            //List<int> ans = new List<int>();
            //foreach (var item in B)
            //{
            //    int minDistance = int.MaxValue;
            //    int distance;
            //    if (A[item[0] - 1][item[1] - 1] == 0)
            //    {
            //        for (int k = 0; k < q.Count; k++)
            //        {
            //            Matrix matrix = q.Dequeue();
            //            int qRow = matrix.row;
            //            int qCol = matrix.col;
            //            distance = Math.Abs(qRow - (item[0] - 1)) + Math.Abs(qCol - (item[1] - 1));
            //            minDistance = Math.Min(minDistance, distance);
            //            if (minDistance == 1)
            //            {
            //                q.Enqueue(matrix);
            //                break;
            //            }
            //            q.Enqueue(matrix);
            //        }
            //        ans.Add(minDistance);
            //    }
            //    else
            //    {
            //        ans.Add(0);
            //    }
            //}
            //return ans;
            #endregion

            #region Approach 2 - Graph - O(N * M)
            var ans = new List<int>();
            int rows = A.Count;
            int cols = A[0].Count;
            var visited = new int[rows,cols];
            var dist = new int[rows,cols];
            Queue<MatrixWithDistance> q = new Queue<MatrixWithDistance>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (A[i][j] == 1)
                    {
                        q.Enqueue(new MatrixWithDistance(i, j, 0));
                        visited[i, j] = 1;
                    }
                }
            }
            while (q.Count > 0)
            {
                // while queue count is > 0, pop from queue.
                // mark its distance
                // start exploring at all sides for this node
                // if any of the adjacent nodes is not visited, mark as visited and add them to the queue
                // if it is visited, continue to the next adjacent node
                var dequeued = q.Dequeue();
                dist[dequeued.row, dequeued.col] = dequeued.distance;
                if (dequeued.row > 0)
                {
                    if (visited[dequeued.row - 1, dequeued.col] == 0)
                    {
                        visited[dequeued.row - 1, dequeued.col] = 1;
                        q.Enqueue(new MatrixWithDistance(dequeued.row - 1, dequeued.col, dequeued.distance + 1));
                    }
                }
                if (dequeued.row < rows - 1)
                {
                    if (visited[dequeued.row + 1, dequeued.col] == 0)
                    {
                        visited[dequeued.row + 1, dequeued.col] = 1;
                        q.Enqueue(new MatrixWithDistance(dequeued.row + 1, dequeued.col, dequeued.distance + 1));
                    }
                }
                if (dequeued.col > 0)
                {
                    if (visited[dequeued.row, dequeued.col - 1] == 0)
                    {
                        visited[dequeued.row, dequeued.col - 1] = 1;
                        q.Enqueue(new MatrixWithDistance(dequeued.row, dequeued.col - 1, dequeued.distance + 1));
                    }
                }
                if (dequeued.col < cols - 1)
                {
                    if (visited[dequeued.row, dequeued.col + 1] == 0)
                    {
                        visited[dequeued.row, dequeued.col + 1] = 1;
                        q.Enqueue(new MatrixWithDistance(dequeued.row, dequeued.col + 1, dequeued.distance + 1));
                    }
                }
            }
            foreach (var item in B)
            {
                ans.Add(dist[item[0] - 1, item[1] - 1]);
            }
            return ans;
            #endregion
        }

        static void Main(string[] args)
        {
            NearestHotel(
                new List<List<int>>
                {
                    new List<int> { 0, 0 },
                    new List<int> { 1, 0 }
                },
                new List<List<int>>()
                {
                    new List<int> { 1, 1 },
                    new List<int> { 2, 1 },
                    new List<int> { 1, 2 }
                }).ForEach(x => Console.WriteLine(x));
            NearestHotel(
                new List<List<int>>
                {
                    new List<int> { 0, 0, 0, 1 },
                    new List<int> { 0, 0, 1, 1 },
                    new List<int> { 0, 1, 1, 0 }
                },
                new List<List<int>>()
                {
                    new List<int> { 1, 1 },
                    new List<int> { 2, 1 },
                    new List<int> { 1, 2 },
                    new List<int> { 2, 2 },
                    new List<int> { 3, 1 },
                    new List<int> { 3, 2 }
                }).ForEach(x => Console.WriteLine(x));
            NearestHotel(
                new List<List<int>>
                {
                    new List<int> { 0, 0, 0 },
                    new List<int> { 0, 1, 0 },
                    new List<int> { 1, 0, 1 }
                },
                new List<List<int>>()
                {
                    new List<int> { 1, 1 },
                    new List<int> { 2, 1 },
                    new List<int> { 1, 2 },
                    new List<int> { 2, 2 },
                    new List<int> { 3, 1 },
                    new List<int> { 3, 2 }
                }).ForEach(x => Console.WriteLine(x));
        }
    }
}
