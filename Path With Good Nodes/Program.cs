namespace Path_With_Good_Nodes
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static LinkedList<int>[] adj;
        public class Graph
        {
            public Graph(int x)
            {
                adj = new LinkedList<int>[x];
                for (int i = 0; i < adj.Length; i++)
                {
                    adj[i] = new LinkedList<int>();
                }
            }

            public void Add(int x, int y)
            {
                adj[x].AddLast(y);
                adj[y].AddLast(x);
            }
        }

        public class CustomStackType
        {
            public int val;
            public bool isLeaf;
            public CustomStackType(int val, bool isLeaf)
            {
                this.val = val; this.isLeaf = isLeaf;
            }
        }

        public static int Solve(List<int> A, List<List<int>> B, int C)
        {
            Graph g = new Graph(A.Count + 1);
            foreach (var item in B)
            {
                g.Add(item[0], item[1]);
            }
            var ans = DFS(g, A, C);
            adj = null;
            return ans;
        }

        public static int DFS(Graph g, List<int> a, int c)
        {
            Stack<CustomStackType> stack = new Stack<CustomStackType>();
            stack.Push(new CustomStackType(1, false));
            int ans = 0;
            int goodNodeCnt = a[0];
            while (stack.Count > 0)
            {
                var peeked = stack.Peek();
                while (adj[peeked.val].Count > 0)
                {
                    var nextNode = adj[peeked.val].First.Value;
                    goodNodeCnt += a[nextNode - 1];
                    adj[peeked.val].Remove(nextNode);
                    adj[nextNode].Remove(peeked.val);
                    var isLeaf = adj[nextNode].Count > 0 ? false : true;
                    stack.Push(new CustomStackType(nextNode, isLeaf));
                    peeked = stack.Peek();
                }
                if (goodNodeCnt <= c && peeked.isLeaf)
                    ans++;
                goodNodeCnt -= a[peeked.val - 1];
                stack.Pop();
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0 }, new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 1, 5 },
                new List<int> { 1, 6 },
                new List<int> { 2, 3 },
                new List<int> { 2, 4 },
                new List<int> { 3, 7 },
                new List<int> { 3, 8 },
                new List<int> { 3, 9 },
                new List<int> { 3, 10 },
            }, 2));
            Console.WriteLine(Solve(new List<int> { 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1 }, new List<List<int>>
            {
                new List<int> { 10, 6 },
                new List<int> { 3, 2 },
                new List<int> { 12, 7 },
                new List<int> { 9, 5 },
                new List<int> { 1, 2 },
                new List<int> { 8, 3 },
                new List<int> { 1, 7 },
                new List<int> { 4, 2 },
                new List<int> { 6, 3 },
                new List<int> { 11, 4 },
                new List<int> { 5, 3 },
                new List<int> { 13, 11 },
            }, 7));
        }
    }
}
