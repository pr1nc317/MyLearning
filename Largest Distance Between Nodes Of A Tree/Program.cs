namespace Largest_Distance_Between_Nodes_Of_A_Tree
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static List<List<int>> tree = new List<List<int>>();
        public static int diameter = 0;
        public static int[] height;

        public static int Solve(List<int> A)
        {
            var root = A.IndexOf(-1);
            height = new int[A.Count];
            for (int i = 0; i < A.Count; i++)
            {
                tree.Add(new List<int>());
            }
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == -1) continue;
                tree[A[i]].Add(i);
            }
            DFS(root);
            tree = new List<List<int>>();
            height = null;
            int ans = diameter - 1;
            diameter = 0;
            return ans;
        }

        public static void DFS(int x)
        {
            int max1 = 0, max2 = 0;
            foreach (var item in tree[x])
            {
                DFS(item);
                height[x] = Math.Max(height[x], height[item]);
                if (height[item] > max1)
                {
                    max2 = max1;
                    max1 = height[item];
                }
                else if (height[item] > max2)
                {
                    max2 = height[item];
                }
            }
            height[x] += 1;

            // Diameter of a tree can be calculated as
            // diameter passing through the node
            // diameter doesn't includes the cur node
            diameter = Math.Max(diameter, height[x]);
            diameter = Math.Max(diameter, max1 + max2 + 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { -1 }));  //0
            Console.WriteLine(Solve(new List<int> { -1, 0, 0, 0, 3 }));  //3
            Console.WriteLine(Solve(new List<int> { -1, 0, 0, 2, 3, 3 }));  //4
            Console.WriteLine(Solve(new List<int> { -1, 0, 0, 0, 3, 4, 1 }));  //5
            Console.WriteLine(Solve(new List<int> { 1, 2, -1, 2, 1, 3, 3, 6, 7, 7 }));  //6
            Console.WriteLine(Solve(new List<int> { -1, 0, 0, 1, 0, 4, 5, 5, 5, 6, 8, 7, 10, 2, 2, 1, 12, 6, 13, 1, 16, 1, 2, 14, 5, 7, 13, 18, 26, 24, 16, 3, 21, 7, 3, 0, 32, 13, 19, 13, 1, 25, 38, 32, 3, 41, 13, 6, 14, 12, 38, 20, 13, 19, 5, 4, 22, 9, 21, 9, 55, 53, 61, 0, 55, 27, 20, 11, 51, 50, 48, 53, 42, 9, 48, 17, 38, 27, 0, 36, 51, 26, 33, 5, 22, 67, 15, 78, 28, 65, 69, 14, 24, 28, 9, 27, 18, 59, 28, 40 }));  //15
        }
    }
}
