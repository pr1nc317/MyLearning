namespace Sort_array_with_squares_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> Solve(List<int> A)
        {
            int i = 0, k = 0, n = A.Count;
            var ansList = new List<int>(n);
            for (i = 0; i < A.Count; i++)
            {
                if (A[i] >= 0)
                    break;                    
            }
            k = i - 1;
            while (k >= 0 && i < n)
            {
                int kSquare = A[k] * A[k];
                int iSquare = A[i] * A[i];
                if (kSquare < iSquare)
                {
                    ansList.Add(kSquare);
                    k--;
                }
                else
                {
                    ansList.Add(iSquare);
                    i++;
                }
            }

            while(i < n)
            {
                int iSquare = A[i] * A[i];
                ansList.Add(iSquare);
                i++;
            }

            while (k >= 0)
            {
                int kSquare = A[k] * A[k];
                ansList.Add(kSquare);
                k--;
            }

            return ansList;
        }

        static void Main(string[] args)
        {
            Solve(new List<int> { -6, -3, -1, 0, 0, 2, 4, 5 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
