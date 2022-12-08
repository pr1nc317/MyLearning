namespace Integer_To_Roman
{
    using System;

    class Program
    {
        public static string IntToRoman(int A)
        {
            #region Approach 1
            //string str = string.Empty;
            //string[] thousands = new string[] { "", "M", "MM", "MMM" };
            //string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            //string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            //string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            //int mul = 1000;
            //while (mul != 0)
            //{
            //    switch (mul)
            //    {
            //        case 1000:
            //            str += thousands[A / mul]; break;
            //        case 100:
            //            str += hundreds[A / mul]; break;
            //        case 10:
            //            str += tens[A / mul]; break;
            //        case 1:
            //            str += ones[A / mul]; break;
            //    }
            //    A %= mul;
            //    mul /= 10;
            //}
            //return str;
            #endregion

            #region Approach 2
            string str = string.Empty;
            int[] nums = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
            string[] romans = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            while (A != 0)
            {
                int idx = nums.Length - 1;
                while (A < nums[idx])
                    idx--;
                str += romans[idx];
                A -= nums[idx];
            }
            return str;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3999));
        }
    }
}
