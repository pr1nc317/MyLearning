namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<string> FizzBuzz(int A)
        {
            var list = new List<string>();
            for (int i = 1; i <= A; i++)
            {
                if (i % 15 == 0)
                {
                    list.Add("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }

                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }

                else
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            FizzBuzz(15).ForEach(x => Console.WriteLine(x));
        }
    }
}
