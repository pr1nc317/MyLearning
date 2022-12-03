namespace Zigzag_String
{
    using System;
    using System.Text;

    class Program
    {
        public static string Convert(string A, int B)
        {
            StringBuilder sb = new StringBuilder();
            string dir;
            if (B == 1) return A;
            for (int i = 0; i < B; i++)
            {
                int k = i;
                dir = "D";
                for (int j = i; j < A.Length; j++)
                {
                    if (k == i)
                    {
                        sb.Append(A[j]);
                    }
                    if (k == B - 1)
                    {
                        dir = "U";
                    }
                    if (k == 0)
                    {
                        dir = "D";
                    }
                    if (dir == "D") k++;
                    else if (dir == "U") k--;
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Convert("PAYPALISHIRING", 3));
            //Console.WriteLine(Convert("ABCD", 2));
            //Console.WriteLine(Convert("QUTUBVIHAR", 5));
            //Console.WriteLine(Convert("MEENABAZAAR", 7));
            Console.WriteLine(Convert("QUTUBVIHAR", 1));
        }
    }
}
