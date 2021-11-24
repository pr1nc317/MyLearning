namespace Set_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int SetIntersection(List<List<int>> A)
        {
            A = A.OrderBy(x => x[0]).ThenBy(y => y[1]).ToList();
            int i = A[^1][0];
            int j = i + 1;
            int count = 2;

            for(int k = A.Count-2; k>=0; k--)
            {
                if(i > A[k][1])
                {
                    i = A[k][0];
                    j = i + 1;
                    count += 2;
                }
                else if (i > A[k][0] && j > A[k][1])
                {
                    j = i;
                    i = A[k][0];
                    count++;
                }
                else if (i == A[k][0] && j> A[k][1])
                {
                    j = i + 1;
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            SetIntersection(new List<List<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 3, 6 },
                new List<int> { 2, 5 },
                new List<int> { 3, 5 }            
            });
        }
    }
}
