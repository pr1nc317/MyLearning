namespace Greatest_Common_Divisor
{
    using System;

    class Program
    {
        public static int GCD(int A, int B)
        {
            #region Solution 1
            //if (A == 0) return B;
            //else if (B == 0) return A;
            //int small = A > B ? B : A;
            //int big = A < B ? B : A;
            //int s;
            //while (big % small != 0)
            //{
            //    s = small;
            //    small = big % small;
            //    big = s;
            //}
            //return small;
            #endregion

            #region Optimized Solution
            while (B != 0)
            {
                int rem = A % B;
                A = B;
                B = rem;
            }
            return A;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GCD(11, 10));
        }
    }
}
