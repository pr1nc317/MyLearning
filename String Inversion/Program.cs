namespace String_Inversion
{
    using System;
    using System.Text;

    class Program
    {
        public static string Solve(string A)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in A)
            {
                if (item - 'a' >= 0)
                {
                    sb.Append(item.ToString().ToUpper());
                }
                else sb.Append(item.ToString().ToLower());
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("InterviewBit"));
        }
    }
}
