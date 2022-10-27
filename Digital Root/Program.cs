namespace Digital_Root
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(int A)
        {
            #region Method 1 - using loops
            //int ans = 0;
            //int sum = 0;
            //while (A > 0)
            //{
            //    sum += A % 10;
            //    A /= 10;
            //    while (sum > 0 || ans / 10 > 0)
            //    {
            //        ans += sum % 10;
            //        sum /= 10;
            //        if (sum == 0 && ans / 10 > 0)
            //        {
            //            sum = ans;
            //            ans = 0;
            //        }
            //    }
            //}
            //if (ans == 0) return sum;
            //return ans;
            #endregion

            #region Method 2 - using list
            int ans = A;
            while (A >= 10)
            {
                var arr = A.ToString();
                var list = new List<int>();
                foreach (var item in arr)
                {
                    list.Add(Convert.ToInt32(item.ToString()));
                }
                ans = list.Sum();
                A = ans;
            }
            return ans;
            #endregion
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(99));
        }
    }
}
