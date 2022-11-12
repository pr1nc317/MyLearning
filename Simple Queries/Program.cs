namespace Simple_Queries
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static ulong Mod = 1000000007;
        private static ulong[] L = new ulong[100001];
        private static ulong[] R = new ulong[100001];

        public static int Pow(int n, int k)
        {
            if (k == 0)
                return 1;
            if (k == 1)
                return n;
            ulong res = (ulong)Pow(n, k / 2);
            res = (res * res) % Mod;
            return (int)(((k & 1) == 0) ? res : ((ulong)res * (ulong)n) % Mod);
        }

        public static int CountDivisors(int x)
        {
            int count = 2;
            var upperLimit = Math.Floor(Math.Sqrt(x));
            for (long i = 2; i <= upperLimit; i++)
            {
                if (x % i == 0)
                {
                    count++;
                    long div = x / i;
                    if (div != i)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int F(int n)
        {
            int c = CountDivisors(n);
            return (c & 1) == 0 ? Pow(n, c / 2) : (int)(((ulong)Pow(n, c / 2) * ((ulong)Math.Sqrt(n) % Mod)) % Mod);
        }

        public static List<int> Solve(List<int> A, List<int> B)
        {
            List<int> res = new List<int>();
            var M = new SortedDictionary<int, ulong>();
            var C = new List<KeyValuePair<int, ulong>>();
            var D = new List<KeyValuePair<int, ulong>>();
            var S = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {
                L[i] = 1;
                while (S.Count > 0 && A[S.Peek()] <= A[i])
                    L[i] += L[S.Pop()];
                S.Push(i);
            }
            S.Clear();
            for (int i = A.Count - 1; i >= 0; i--)
            {
                R[i] = 1;
                while (S.Count > 0 && A[S.Peek()] < A[i])
                    R[i] += R[S.Pop()];
                S.Push(i);
            }
            for (int i = 0; i < A.Count; i++)
            {
                ulong v = L[i] * R[i];
                if (M.ContainsKey(A[i]))
                    M[A[i]] += v;
                else
                    M.Add(A[i], v);
            }
            foreach (var item in M)
                C.Add(new KeyValuePair<int, ulong>(F(item.Key), item.Value));
            C.Sort((x, y) => y.Key.CompareTo(x.Key));
            ulong cnt = 0;
            foreach (var item in C)
            {
                cnt += item.Value;
                D.Add(new KeyValuePair<int, ulong>(item.Key, cnt));
            }
            foreach (var p in B)
            {
                int min = 0, max = D.Count - 1;
                while (min < max)
                {
                    int m = (min + max) / 2;
                    if (D[m].Value < (ulong)p)
                        min = m + 1;
                    else
                        max = m;
                }
                res.Add(D[min].Key);
            }
            return res;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(CountDivisors1(1456231526));
            //Solve(new List<int> { 1, 4, 2 }, new List<int> { 1, 2, 3, 4, 5, 6}).ForEach(x => Console.WriteLine(x));
            //Solve(new List<int> { 1, 3 }, new List<int> { 1 }).ForEach(x => Console.WriteLine(x));
            Solve(new List<int> { 39, 99, 70, 24, 49, 13, 86, 43, 88, 74, 45, 92, 72, 71, 90, 32, 19, 76, 84, 46, 63, 15, 87, 1, 39, 58, 17, 65, 99, 43, 83, 29, 64, 67, 100, 14, 17, 100, 81, 26, 45, 40, 95, 94, 86, 2, 89, 57, 52, 91, 45 }, new List<int> { 1221, 360, 459, 651, 958, 584, 345, 181, 536, 116, 1310, 403, 669, 1044, 1281, 711, 222, 280, 1255, 257, 811, 409, 698, 74, 838 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
