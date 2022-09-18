namespace _69_Sqrt_x_
{
    using System;

    class Program
    {
        static int MySqrt(int x)
        {
            #region Binary Search Method
            //long low = 0; long high = x;
            //while (high - low > 1)
            //{
            //    long mid = (high + low) / 2;
            //    if (mid * mid > x)
            //    {
            //        high = mid - 1;
            //    }
            //    else low = mid;
            //}
            //if (high * high <= x) return (int) high;
            //else return (int) low;
            #endregion

            #region Babylonian Method
            long ans = x;
            while (ans * ans > x)
                ans = (ans + x / ans) / 2;
            return (int)ans;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(2147395599));
        }
    }
}
