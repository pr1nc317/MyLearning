namespace Product_of_Digits
{
    using System;

    class Program
    {
        public static int Solve(int A)
        {
            int prod = 1;
            var str = A.ToString();
            if (str.Contains("0"))
            {
                return 0;
            }
            foreach (var item in str)
            {
                prod *= Convert.ToInt32(item.ToString());
            }
            return prod;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(999999999));
        }
    }
}
