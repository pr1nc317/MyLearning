namespace Atoi
{
    using System;

    class Program
    {
        public static int Atoi(string A)
        {
            string str = string.Empty;
            double ans;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 43 || A[i] == 45 || A[i] == 32)
                {
                    if (str.Length != 0) break;
                }
                if ((A[i] - '0' >= 0 && A[i] - '0' <= 9) || A[i] == 43 || A[i] == 45)
                {
                    str += A[i];
                }
                else break;
            }
            if (string.IsNullOrEmpty(str)) return 0;
            while (str.Contains("-0"))
            {
                str = str.Replace("-0", "-");
            }
            if (str.Length > 10 && str.Contains("+")) return int.MaxValue;
            if (str.Length > 10 && str.Contains("-")) return int.MinValue;
            if (str.Length == 1 && (str.Contains("-") || str.Contains("+"))) return 0;
            ans = Convert.ToDouble(str);
            if (ans > int.MaxValue) return int.MaxValue;
            if (ans < int.MinValue) return int.MinValue;
            return (int)ans;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //var a = Convert.ToDouble("-");
            //Console.WriteLine(a);
            Console.WriteLine(Atoi("-6435D56183011M11 648G1 903778065 762 75316456373673B5 334 19885 90668 8 98K X277 9846"));
        }
    }
}
