namespace _66_PlusOne
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static int[] PlusOne(int[] digits)
        {
            int carry = 1;
            int[] ans = null;
            if (digits.Where(x => x != 9).Count() > 0)
            {
                ans = new int[digits.Length];
            }
            else ans = new int[digits.Length + 1];
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if ((digits[i] + carry) / 10 == 1)
                {
                    ans[i] = (digits[i] + carry) % 10;
                    carry = 1;
                    continue;
                }
                ans[i] = digits[i] + carry;
                carry = 0;
            }
            if (carry > 0)
            {
                ans[0] = carry;
            }
            return ans;

        }

        static void Main(string[] args)
        {
            PlusOne(new int[] { 8, 9, 9 }).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
