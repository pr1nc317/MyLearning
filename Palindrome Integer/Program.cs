namespace Palindrome_Integer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        public static int IsPalindrome(int A)
        {
            #region Solution 1
            //if (A < 0) return 0;
            //var a = A.ToString();
            //var b = new string(a.Reverse().ToList().ToArray());
            //if (a.Equals(b)) return 1;
            //else return 0;
            #endregion

            #region Solution 2
            int temp = A;
            if (A < 0) return 0;
            if (A == 0) return 1;
            string str = "";
            while(A > 0)
            {
                int rem = A % 10;
                A /= 10;
                str += rem;
            }
            if (str.Equals(temp.ToString())) return 1;
            else return 0;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(2147447412));
        }
    }
}
