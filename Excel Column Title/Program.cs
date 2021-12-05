namespace Excel_Column_Title
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static string ConvertToTitle(int A)
        {
            int quotient = A;
            var list = new List<char>();
            while(quotient > 0)
            {
                int rem = quotient % 26;
                quotient /= 26;
                if (rem == 0)
                {
                    rem = 26;
                    quotient--;
                }
                list.Insert(0, (char)(64 + rem));
            }
            return new string(list.ToArray());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToTitle(54));
        }
    }
}
