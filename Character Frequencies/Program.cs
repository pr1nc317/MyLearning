namespace Character_Frequencies
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Solve(string A)
        {
            int[] arr = new int[26];
            for (int i = 0; i < A.Length; i++)
            {
                arr[A[i] - 'a']++;
            }
            var freq = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (arr[A[i] - 'a'] != 0)
                    freq.Add(arr[A[i] - 'a']);
                else continue;
                arr[A[i] - 'a'] = 0;
            }
            return freq;
        }

        static void Main(string[] args)
        {
            Solve("amitmansi").ForEach(x => Console.Write(x + " "));
        }
    }
}
