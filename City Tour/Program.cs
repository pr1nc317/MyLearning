namespace City_Tour
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static ulong mod = 1000000007;

        public static int Solve(int A, List<int> B)
        {
            ulong ans;

            if (B.Count == 1 && B[0] == 1) return 1;
            if (B.Count == 0) return 0;

            // Create temp array having all the unvisited cities gaps
            B.Sort();
            List<int> temp = new List<int>();
            temp.Add(B[0] - 1);
            for (int i = 1; i < B.Count; i++)
            {
                temp.Add(B[i] - B[i - 1] - 1);
            }
            temp.Add(A - B[B.Count - 1]);

            // Factorial of unvisited cities
            ans = Fact((ulong)(A - B.Count));

            // Factorial of n1, n2.... ni
            for (int i = 0; i < temp.Count; i++)
            {
                ans *= Pow(Fact((ulong)temp[i]), mod - 2) % mod;
                ans %= mod;
            }

            // Calculating 2^N
            ulong z = 1;
            for (int i = 0; i < temp.Count; i++)
            {                
                if (i == 0 || i == temp.Count - 1)
                    z *= 1;
                else
                {
                    if (temp[i] < 2) continue;
                    else
                    {
                        z *= Pow(2, (ulong)temp[i] - 1);
                        z %= mod;
                    }
                }
            }
            ans = (ans * z) % mod;

            return (int)(ans % mod);
        }

        public static ulong Fact(ulong N)
        {
            ulong ans = 1;
            for (ulong i = 1; i <= N; i++)
            {
                ans *= i;
                ans %= mod;
            }
            return ans;
        }

        // Return A^N
        public static ulong Pow(ulong A, ulong N)
        {
            if (N == 1) return A;
            if (N == 0) return 1;
            ulong temp = Pow(A, N / 2) % mod;

            if (N % 2 == 0) return ((temp * temp) % mod);

            return ((((A * temp) % mod) * temp) % mod) % mod;
        }

        //public static int Power(int A, int N)
        //{
        //    if (N == 1) return A;
        //    if (N == 0) return 1;
        //    int temp = Power(A, N / 2);

        //    if (N % 2 == 0) return (temp) * (temp);

        //    return temp * temp * temp;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(5, new List<int> {3 }));
        }
    }
}
