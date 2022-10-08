namespace Palindromic_Time
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            int counter = 0;
            int h1 = Convert.ToInt32(A[0].ToString());
            int h2 = Convert.ToInt32(A[1].ToString());
            int m1 = Convert.ToInt32(A[3].ToString());
            int m2 = Convert.ToInt32(A[4].ToString());
            while (h1 != m2 || h2 != m1)
            {
                counter++;
                m2 = (m2 + 1) % 10;
                if (m2 != 0)
                {
                    continue;
                }
                m1 = (m1 + 1) % 6;
                if (m1 != 0) continue;
                if (h2 == 3 && h1 == 2)
                {
                    h2 = 0; h1 = 0; continue;
                }
                h2 = (h2 + 1) % 10;
                if (h2 != 0) continue;
                h1++;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("21:59"));
        }
    }
}
