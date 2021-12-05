namespace Excel_Column_Number
{
    using System;

    class Program
    {
        public static int TitleToNumber(string A)
        {
            var arr = A.ToCharArray();
            int ans = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var num = (int)arr[i] - 64;
                ans += (int)Math.Pow(26, arr.Length - 1 - i) * num;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TitleToNumber("BA"));
        }
    }
}
