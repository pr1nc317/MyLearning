namespace Make_Equal_Elements_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            int min = A.Min();
            int max = A.Max();
            int n = A.Count;
            if (min == max) return 1;
            if (B < 0)
            {
                if (!(min - B == max || max + B == min || min - B == max + B)) return 0;
            }
            else
            {
                if (!(min + B == max || max - B == min || min + B == max - B)) return 0;
            }
            
            for (int i = 0; i < n; i++)
            {
                if (A[i] < max && A[i] > min)
                {
                    if (!(A[i] - min == B && max - A[i] == B))
                        return 0;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1,1,4}, 2));
        }
    }
}
