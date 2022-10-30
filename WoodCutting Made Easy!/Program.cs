namespace WoodCutting_Made_Easy
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A, int B)
        {
            int start = 0;
            int end = 1000000;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int wood = WoodCollected(A, mid);
                if (wood == B) return mid;
                else if (wood < B) end = mid - 1;
                else if (wood > B) start = mid + 1;
            }
            return start - 1;
        }

        public static int WoodCollected(List<int> A, int B)
        {
            int sum = 0;
            for (int i = A.Count - 1; i >= 0; i--)
            {
                if (A[i] > B)
                {
                    sum += A[i] - B;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 4, 42, 40, 26, 46 }, 20));
            Console.WriteLine(Solve(new List<int> { 20, 15, 10, 17 }, 7));
            Console.WriteLine(Solve(new List<int> { 114, 55, 95, 131, 77, 111, 141 }, 95));
        }
    }
}
