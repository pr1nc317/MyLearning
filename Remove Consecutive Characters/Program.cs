namespace Remove_Consecutive_Characters
{
    using System;

    class Program
    {
        public static string Solve(string A, int B)
        {
            int matchingCount = 1;
            if (A.Length == 1 && B == 1) return "";
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == A[i - 1])
                {
                    matchingCount++;
                }
                else
                {
                    if (matchingCount == B)
                    {
                        A = A.Remove(i - B, B);
                        matchingCount = 1;
                        i -= B;
                    }
                    else
                    {
                        matchingCount = 1;
                    }
                }
            }
            if (matchingCount == B)
            {
                A = A.Remove(A.Length - B, B);
            }
            return A;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("dcd", 2));
        }
    }
}
