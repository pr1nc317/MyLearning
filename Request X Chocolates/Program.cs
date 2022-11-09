namespace Request_X_Chocolates
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<List<int>> A, int B)
        {
            SortedDictionary<int, List<int>> dict = new SortedDictionary<int, List<int>>();
            foreach (var item in A)
            {
                if (dict.ContainsKey(item[0]))
                {
                    dict[item[0]].Add(item[1]);
                }
                else dict.Add(item[0], new List<int> { item[1] });
            }
            int start = 0;
            int end = B;
            int ans = 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (IsValid(dict, B, mid))
                {
                    ans = mid;
                    start = mid + 1;
                }
                else end = mid - 1;
            }
            return ans;
        }

        public static bool IsValid(SortedDictionary<int, List<int>> dict, int B, int mid)
        {
            int total = 0;
            foreach (var item in dict)
            {
                int curr = 0;
                foreach (var req in item.Value)
                {
                    if (curr + req <= mid)
                    {
                        curr += req;
                    }
                    else break;
                }
                total += curr;
            }
            return total <= B;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<List<int>> {
                new List<int> { 1, 2 },
                new List<int> { 2, 1 },
                new List<int> { 1, 4 },
                new List<int> { 2, 9 },
                new List<int> { 1, 1 },
                new List<int> { 3, 2 }
            }, 6));
            Console.WriteLine(Solve(new List<List<int>> {
                new List<int> { 1, 2 },
                new List<int> { 2, 1 },
                new List<int> { 1, 4 },
                new List<int> { 2, 9 },
                new List<int> { 1, 1 },
                new List<int> { 3, 2 }
            }, 1));
        }
    }
}