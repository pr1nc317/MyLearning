namespace Reverse_integer
{
    using System;

    class Program
    {
        public static int Reverse(int A)
        {
            int temp = A;
            A = Math.Abs(A);
            string str = "";
            while (A > 0)
            {
                int rem = A % 10;
                A /= 10;
                str += rem;
            }
            int ans = 0;
            Int32.TryParse(str, out ans);
            if (temp < 0) return -ans;
            else return ans;
        }

        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(Reverse(-635));
        }
    }
}
