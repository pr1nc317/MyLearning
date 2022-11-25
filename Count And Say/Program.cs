namespace Count_And_Say
{
    using System;
    using System.Text;

    class Program
    {
        public static string CountAndSay(int A)
        {
            var str = new StringBuilder("1");
            int i; int j;
            for (i = 2; i <= A; i++)
            {
                var newStr = new StringBuilder();
                int count = 1;
                for (j = 1; j < str.Length; j++)
                {
                    if (str[j] == str[j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        newStr.Append(count);
                        newStr.Append(str[j - 1] - '0');
                        count = 1;
                    }
                }
                newStr.Append(count); 
                newStr.Append(str[j - 1] - '0');
                str = newStr;
            }
            return str.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountAndSay(9));
        }
    }
}
