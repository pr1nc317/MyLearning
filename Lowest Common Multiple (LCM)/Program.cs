namespace Lowest_Common_Multiple__LCM_
{
    using System;

    class Program
    {
        public static long Solve(int A, int B)
        {
            // LCM of A,B = A*B / GCD(A,B)
            long lcm;
            var gcd = GCD(A, B);
            lcm = (long)A * (long)B;
            return lcm / gcd;
        }

        public static int GCD(int A, int B)
        {
            if (B == 0)
            {
                return A;
            }
            return GCD(B, A % B);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(999999999, 999999998));
            //Console.WriteLine(Solve(6, 9));
        }
    }
}
