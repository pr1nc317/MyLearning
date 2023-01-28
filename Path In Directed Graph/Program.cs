namespace Path_In_Directed_Graph
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int vertex;
        public static LinkedList<int>[] adj;

        public class Graph
        {
            public Graph(int v)
            { 
                vertex = v;
                adj = new LinkedList<int>[v];
                for (int i = 0; i < vertex; i++)
                {
                    adj[i] = new LinkedList<int>();
                }
            }

            public void Add(int u, int v)
            {
                adj[u - 1].AddLast(v - 1);
            }
        }

        public static int Solve(int A, List<List<int>> B)
        {
            // Initialize Graph
            var graph = new Graph(A);
            foreach (var item in B)
            {
                graph.Add(item[0], item[1]);
            }
            
            // BFS Implementation
            int[] vis = new int[vertex];
            LinkedList<int> q = new LinkedList<int>();
            q.AddLast(0);
            vis[0] = 1;
            while (q.Count > 0)
            {
                int u = q.First.Value;
                q.RemoveFirst();
                var enumerator = adj[u].GetEnumerator();
                while (enumerator.MoveNext())
                {
                    int v = enumerator.Current;
                    if (v == A - 1)
                    {
                        ClearGlobalVars();
                        return 1;
                    }
                    if (vis[v] == 0)
                    {
                        vis[v] = 1;
                        q.AddLast(v);
                    }
                }
            }
            ClearGlobalVars();
            return 0;
        }

        public static void ClearGlobalVars()
        {
            vertex = 0;
            adj = null;
        }

        static void Main(string[] args)
        {
            var list = new List<List<int>>()
            {
                new List<int>{ 1, 2 },
                new List<int>{ 4, 1 },
                new List<int>{ 2, 4 },
                new List<int>{ 3, 4 },
                new List<int>{ 5, 2 },
                new List<int>{ 1, 3 }
            };
            Console.WriteLine(Solve(5, list));
            list.Clear();
            list = new List<List<int>>()
            {
                new List<int>{ 1, 2 },
                new List<int>{ 2, 3 },
                new List<int>{ 3, 4 },
                new List<int>{ 4, 5 }
            };
            Console.WriteLine(Solve(5, list));
        }
    }
}
