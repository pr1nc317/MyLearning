namespace Find_Last_Digit
{
    using System;

    class Program
    {
        public static int Solve(string A, string B)
        {
            int lastDigitofA = Convert.ToInt32(A[A.Length - 1].ToString());
            int b = 0;
            if (B.Length >= 2)
                b = Convert.ToInt32(B[B.Length - 2].ToString() + B[B.Length - 1].ToString());
            else b = Convert.ToInt32(B[B.Length - 1].ToString());
            var rem = b % 4;
            if (lastDigitofA == 0 || lastDigitofA == 1 || lastDigitofA == 5 || lastDigitofA == 6)
            {
                return lastDigitofA;
            }
            else if (lastDigitofA % 2 == 0)
            {
                if (rem == 0)
                {
                    return 6;
                }
                else
                {
                    return Convert.ToInt32(Math.Pow(lastDigitofA, rem).ToString()) % 10;
                }
            }
            else
            {
                if (rem == 0)
                {
                    return 1;
                }
                else
                {
                    return Convert.ToInt32(Math.Pow(lastDigitofA, rem).ToString()) % 10;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("8582853859457831778078301406588768841336101472396693874044447931109429811135454336416964887304666733",
                "3361268316093532281604317607524357824300258482139534694045781168569091952758867635638492914893558962"));
        }
    }
}
