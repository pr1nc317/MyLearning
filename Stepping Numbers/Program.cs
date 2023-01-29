namespace Stepping_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        public static List<int> Stepnum(int A, int B)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                BFS(A, B, i, result);
            }
            result.Sort();
            return result;
        }

        public static void BFS(int A, int B, int curr, List<int> result)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(curr);
            while (q.Count > 0)
            {
                var deq = q.Dequeue();
                if (deq > B)
                {
                    continue;
                }
                if (deq >= A)
                    result.Add(deq);
                if (deq == 0)
                    continue;
                var lastDigit = deq % 10;
                var newNum1 = deq * 10 + (lastDigit - 1);
                var newNum2 = deq * 10 + (lastDigit + 1);
                if (lastDigit == 0)
                    q.Enqueue(newNum2);
                else if (lastDigit == 9)
                    q.Enqueue(newNum1);
                else
                {
                    q.Enqueue(newNum1);
                    q.Enqueue(newNum2);
                }
            }
        }

        static void Main(string[] args)
        {
            Stepnum(0, 86).ForEach(x => Console.WriteLine(x));
        }
    }
}
