namespace Implement_Power_Function
{
    using System;

    class Program
    {
        public static int Pow(int x, int n, int d)
        {
            #region Method 1 -- Pikki-Chikki method
            //long mul = x;
            //for (int i = 1; i < n; i++)
            //{
            //    mul *= x;
            //    mul %= d;
            //}
            //if (mul >= 0)
            //    return (int)(mul % d);
            //else return (int)(mul + d);
            #endregion

            #region Method 2 - Optimized
            long res = 1;
            long a = x;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    res *= a;
                    res %= d;
                }
                a *= a;
                a %= d;
                n /= 2;
            }
            res = (res + d) % d;
            return (int)res;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Pow(2, 3, 3));
            Console.WriteLine(Pow(79161127, 99046373, 57263970));
        }
    }
}