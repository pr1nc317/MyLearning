namespace Greater_than_All
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A)
        {
            int count = 1;
            int max = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] > max)
                {
                    count++;
                    max = A[i];
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1,1,3,3,1,2,4}));
        }
    }
}
