namespace Prime_Numbers
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Sieve(int A)
        {
            var arr = new bool[A + 1];
            var list = new List<int>();
            for (int i = 1; i <= A; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(A); i++)
            {
                for (int k = i * i; k <= A; k += i)
                {
                    arr[k] = false;
                }
            }

            for (int i = 2; i <= A; i++)
            {
                if (arr[i] == true)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        static void Main(string[] args)
        {
            Sieve(10).ForEach(x => Console.WriteLine(x));
        }
    }
}
