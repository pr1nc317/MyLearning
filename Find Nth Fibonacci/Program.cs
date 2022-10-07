namespace Find_Nth_Fibonacci
{
    using System;
    using System.Diagnostics;

    class Program
    {
        public static int NthFibonacci(int A)
        {
            #region Recursion - Stack Overflow
            //if (A <= 1) return A;
            //else return NthFibonacci(A - 1) + NthFibonacci(A - 2);
            #endregion
            #region For Loop - TLE
            //int mod = 1000000007;
            //int a = 0; int b = 1;
            //int ans = 0;
            //for (int i = 2; i <= A; i++)
            //{
            //    a %= mod;
            //    b %= mod;
            //    ans = (a + b) % mod;
            //    a = b;
            //    b = ans;
            //}
            //return ans;
            #endregion
            #region Matrix Exponentiation O(logN)
            long[,] mat = new long[,] { { 1, 1 }, { 1, 0 } };
            int mod = 1000000007;
            Power(mat, A - 1, mod);
            return (int)mat[0, 0] % mod;
            #endregion
        }

        public static void Power(long[,] mat, int A, int mod)
        {
            long[,] M = new long[,] { { 1, 1 }, { 1, 0 } };
            if (A <= 1)
            {
                return;
            }
            Power(mat, A / 2, mod);
            MultiplyMatrix(mat, mat, mod);
            if (A % 2 != 0)
            {
                MultiplyMatrix(mat, M, mod);
            }
        }

        public static void MultiplyMatrix(long[,] mat, long[,] mat2, int mod)
        {
            long a = mat[0, 0] * mat2[0, 0] + mat[0, 1] * mat2[1, 0];
            long b = mat[0, 0] * mat2[0, 1] + mat[0, 1] * mat2[1, 1];
            long c = mat[1, 0] * mat2[0, 0] + mat[1, 1] * mat2[1, 0];
            long d = mat[1, 0] * mat2[0, 1] + mat[1, 1] * mat2[1, 1];
            mat[0, 0] = a % mod;
            mat[0, 1] = b % mod;
            mat[1, 0] = c % mod;
            mat[1, 1] = d % mod;
        }

        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(long.MaxValue);
            Console.WriteLine(NthFibonacci(1000000000));
            Console.WriteLine(sw.Elapsed);
        }
    }
}
