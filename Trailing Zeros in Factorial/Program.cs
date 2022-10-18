namespace Trailing_Zeros_in_Factorial
{
    using System;

    class Program
    {
        public static int TrailingZeros(int A)
        {
            //int count = 0;
            //for (int i = 1; i < 70; i++)
            //{
            //    count += A / (int)Math.Pow(5, i);
            //}
            //return count;

            int count = 0;
            while (A > 4)
            {
                count += A / 5;
                A /= 5;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(9446865));
        }
    }
}
