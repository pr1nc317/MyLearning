namespace Integer_To_Roman
{
    using System;

    class Program
    {
        public static string IntToRoman(int A)
        {
            string str = string.Empty;
            string[] thousands = new string[] { "", "M", "MM", "MMM" };
            string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            int mul = 1000;
            while (mul != 0)
            {
                switch (mul)
                {
                    case 1000:
                        str += thousands[A / mul]; break;
                    case 100:
                        str += hundreds[A / mul]; break;
                    case 10:
                        str += tens[A / mul]; break;
                    case 1:
                        str += ones[A / mul]; break;
                }
                A %= mul;
                mul /= 10;
            }
            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(199));
        }
    }
}
