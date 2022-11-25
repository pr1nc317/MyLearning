namespace Bulls_and_Cows
{
    using System;

    class Program
    {
        public static string Solve(string A, string B)
        {
            int bulls = 0;
            int cows = 0;
            int[] arr = new int[10];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                {
                    bulls++;
                    continue;
                }
                if (arr[A[i] - '0'] <= -1)
                {
                    cows++;
                    arr[A[i] - '0']++;
                }
                else arr[A[i] - '0']++;
                if (arr[B[i] - '0'] >= 1)
                {
                    cows++;
                    arr[B[i] - '0']--;
                }
                else arr[B[i] - '0']--;
            }
            return new string(bulls + "A" + cows + "B");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Solve("1807", "0871"));
            Console.WriteLine(Solve("112341", "011115"));
        }
    }
}
