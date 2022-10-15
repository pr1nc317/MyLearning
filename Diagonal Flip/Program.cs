namespace Diagonal_Flip
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<List<int>> Solve(List<List<int>> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i; j < A[i].Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    var temp = A[i][j];
                    A[i][j] = A[j][i];
                    A[j][i] = temp;
                }
            }
            return A;
        }
        static void Main(string[] args)
        {
            Solve(new List<List<int>> { new List<int> { 1, 0, 0, 1},
                                        new List<int> { 1, 1, 1, 0},
                                        new List<int> { 1, 0, 1, 0},
                                        new List<int> { 0, 1, 1, 1}
                                      }).ForEach(x => { x.ForEach(y => Console.Write(y + "")); Console.WriteLine(); });
        }
    }
}
