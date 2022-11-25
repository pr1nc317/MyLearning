namespace Self_Permutation
{
    using System;

    class Program
    {
        public static int PermuteStrings(string A, string B)
        {
            if (A.Length != B.Length) return 0;
            int[] arr = new int[26];
            for (int i = 0; i < A.Length; i++)
            {
                arr[A[i] - 'a']++;
                arr[B[i] - 'a']--;
            }
            foreach (var item in arr)
            {
                if (item != 0) return 0;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PermuteStrings("scaler", "relasc"));
            Console.WriteLine(PermuteStrings("scaler", "interviewbit"));
        }
    }
}
