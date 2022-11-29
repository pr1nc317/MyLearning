namespace Amazing_Subarrays
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            int mod = 10003;
            int count = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (IsVowel(A[i]))
                {
                    count = (count + (A.Length - i)) % mod;
                }
            }
            if (IsVowel(A[A.Length - 1])) count++;
            return count;
        }

        public static bool IsVowel(char A)
        {
            if (A == 'a' || A == 'e' || A == 'i' || A == 'o' || A == 'u' || A == 'A' || A == 'E' || A == 'I' || A == 'O' || A == 'U')
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("ABEE"));
        }
    }
}
