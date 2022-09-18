namespace _412_FizzBuzz
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static IList<string> FizzBuzz(int n)
        {
            var ans = new string[n];
            for (int i = 0; i < n; i++)
            {
                if ((i+1) % 3 == 0 && (i + 1) % 5 == 0) ans[i] = "FizzBuzz";
                else if ((i + 1) % 3 == 0) ans[i] = "Fizz";
                else if ((i + 1) % 5 == 0) ans[i] = "Buzz";
                else ans[i] = (i + 1).ToString();
            }
            return ans;
        }

        static void Main(string[] args)
        {
            FizzBuzz(6).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
