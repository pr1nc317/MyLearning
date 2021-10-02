namespace Staircase
{
    using System;

    class Result
    {

        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void Staircase(int n)
        {
            //First Way - For Loops
            for (int i = 1; i <= n; i++)
            {
                for (int j = n-i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                if(i != n) Console.Write("\r\n");
            }

            //Second Way - String Formatting
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - i - 1).PadRight(n, '#'));
            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Result.Staircase(n);
        }
    }
}
