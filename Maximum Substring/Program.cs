namespace Maximum_Substring
{
    using System;

    class Program
    {
        public static int Solve(string A, int B)
        {
            int maxA = 0;
            for (int i = 0; i < A.Length; i+=B)
            {
                int count = 0;
                for (int j = i; j < i + B && j < A.Length; j++)
                {
                    if (A[j] == 'a') count++;
                }
                if (count > maxA) maxA = count;
            }
            return maxA;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("bbbabaaaaaa", 15));
        }
    }
}
