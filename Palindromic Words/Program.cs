namespace Palindromic_Words
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            var arr = A.Split(" ");
            int countOfPalindromes = 0;
            foreach (var item in arr)
            {
                int i = 0;
                int j = item.Length - 1;
                for (; i < j; i++, j--)
                {
                    if (item[i] != item[j])
                        break;
                }
                if (i >= j) countOfPalindromes++;
            }
            return countOfPalindromes;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("the fastest racecar"));
        }
    }
}
