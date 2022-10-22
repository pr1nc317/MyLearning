namespace Largest_Coprime_Divisor
{
    using System;

    class Program
    {
        public static int LargestCoprimeDivisor(int A, int B)
        {
            // find gcd of A and B and divide A by it until gcd of A and B becomes 1
            var gcd = GCD(A, B);
            while (gcd != 1)
            {
                A = A / gcd;
                gcd = GCD(A, B);
            }
            return A;
        }

        public static int GCD(int A, int B)
        {
            #region Method 1 to find GCD - O(min(a,b)) time and O(1) sapce
            //int res = Math.Min(A, B);
            //while (res > 0)
            //{
            //    if (A % res == 0 && B % res == 0)
            //        break;
            //    res--;
            //}
            //return res;
            #endregion

            #region Method 2 to find GCD - O(log(min(a,b))) time and O(log(min(a,b))) space
            if (B == 0)
            {
                return A;
            }
            return GCD(B, A % B);
            #endregion
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(LargestCoprimeDivisor(30, 12));
            //Console.WriteLine(LargestCoprimeDivisor(9, 3));
            Console.WriteLine(LargestCoprimeDivisor(984980470, 276719888));
        }
    }
}
