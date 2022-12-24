namespace Divide_Integers
{
    using System;

    class Program
    {
        public static int Divide(int A, int B)
        {
            #region Approach 1 - O(a/b) Subtract divisor from dividend until dividend becomes lesser than divisor
            //int sign = (A < 0) ^ (B < 0) ? -1 : 1;
            //int count = 0;
            //if (A == int.MinValue)
            //{
            //    if (B == 1) return int.MinValue;
            //    if (B == -1) return int.MaxValue;
            //}
            //uint dividend;
            //uint divisor;
            //if (A == int.MinValue)
            //    dividend = (uint)int.MaxValue + 1;
            //else
            //    dividend = (uint)Math.Abs(A);
            //if (B == int.MinValue)
            //    divisor = (uint)int.MaxValue + 1;
            //else
            //    divisor = (uint)Math.Abs(B);
            //while (dividend >= divisor)
            //{
            //    dividend -= divisor;
            //    count++;
            //}
            //if (sign == -1) count = -count;
            //return count;
            #endregion

            #region Approach 2 - O(1) Using Logarithms
            //int sign = (A < 0) ^ (B < 0) ? -1 : 1;
            //uint dividend;
            //uint divisor;
            //if (A == int.MinValue)
            //{
            //    if (B == 1) return int.MinValue;
            //    if (B == -1) return int.MaxValue;
            //}
            //if (A == int.MinValue)
            //    dividend = (uint)int.MaxValue + 1;
            //else
            //    dividend = (uint)Math.Abs(A);
            //if (B == int.MinValue)
            //    divisor = (uint)int.MaxValue + 1;
            //else
            //    divisor = (uint)Math.Abs(B);
            //int ans = (int)(Math.Exp(Math.Log(dividend) - Math.Log(divisor)) + 0.0000000001);
            //return sign == -1 ? -ans : ans;
            #endregion

            #region Approach 3 - Dividend = Divisor * Quotient + Remainder
            int sign = (A < 0) ^ (B < 0) ? -1 : 1;
            long dividend;
            long divisor;
            if (A == int.MinValue)
            {
                if (B == 1) return int.MinValue;
                if (B == -1) return int.MaxValue;
            }
            if (A == int.MinValue)
                dividend = (long)int.MaxValue + 1;
            else
                dividend = (long)Math.Abs(A);
            if (B == int.MinValue)
                divisor = (long)int.MaxValue + 1;
            else
                divisor = (long)Math.Abs(B);
            long quotient = 0; long temp = 0;
            for (int i = 31; i >= 0; i--)
            {
                if (temp + (divisor << i) <= dividend)  // checking if divisor*quotient + remainder is less than dividend or not
                {
                    temp += divisor << i;    // divisor << i  is basically multiples of divisor and temp is acting like a resultant of divisor*quotient + remainder
                    quotient |= 1L << i;
                }
            }
            if (sign == -1) quotient = -quotient;
            return (int)quotient;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Divide(-2147483648, -10000000));
        }
    }
}
