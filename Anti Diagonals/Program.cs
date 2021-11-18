namespace Anti_Diagonals
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<List<int>> Diagonal(List<List<int>> A)
        {
            var list = new List<List<int>>();
            int n = A.Count;
            for (int i = 0; i < n; i++)
            {
                var temp = ReturnSmallerDiagonalsBeforeEqualToN(A, i, n);
                list.Add(temp);
            }

            int count = n;
            for (int i = 1; i < n; i++, count++)
            {
                var temp = ReturnSmallerDiagonalsAfterN(A, i, n, count);
                list.Add(temp);
            }
            return list;
        }

        public static List<int> ReturnSmallerDiagonalsBeforeEqualToN(List<List<int>> A, int index, int n)
        {
            var list = new List<int>();
            for (int i = 0, j = index; i < n && j >= 0; i++, j--)
            {
                list.Add(A[i][j]);
            }
            return list;
        }

        public static List<int> ReturnSmallerDiagonalsAfterN(List<List<int>> A, int index, int n, int count)
        {
            var list = new List<int>();
            for (int i = index, j = n-1; i < n && j >= 0; i++, j--)
            {
                list.Add(A[i][j]);
            }
            return list;
        }

        static void Main(string[] args)
        {
            Diagonal(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } })
                .ForEach(x => { x.ForEach(y => Console.Write(" " + y)); Console.WriteLine(); });
        }
    }
}