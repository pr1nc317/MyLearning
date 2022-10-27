namespace Armstrong_Number
{
    using System;

    class Program
    {
        public static int Solve(int A)
        {
            var str = A.ToString();
            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += Math.Pow(Convert.ToInt32(str[i].ToString()), str.Length);
                if (sum > A)
                {
                    return 0;
                }
            }
            if (sum == A)
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(123));
        }
    }
}
