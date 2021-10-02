namespace Large_Factorial
{
    using System;

    class Program
    {
        public static string Solve(int A)
        {
            string result = "";
            int[] res = new int[500];
            res[0] = 1;
            int resSize = 1;
            int prod;
            for (int k = 2; k <= A; k++)
            {
                int carry = 0;
                for (int i = 0; i < resSize; i++)
                {
                    prod = res[i] * k + carry;
                    res[i] = prod % 10;
                    carry = prod / 10;
                }
                while (carry > 0)
                {
                    res[resSize++] = carry;
                    carry /= 10;
                }
            }
            for (int i = resSize - 1; i >= 0; i--)
            {
                result += res[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write(Solve(7));
        }
    }
}
