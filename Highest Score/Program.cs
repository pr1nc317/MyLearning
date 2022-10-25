namespace Highest_Score
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int HighestScore(List<List<string>> A)
        {
            var scores = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < A.Count; i++)
            {
                if (scores.ContainsKey(A[i][0]))
                {
                    scores[A[i][0]].Add(Convert.ToDecimal(A[i][1]));
                }
                else
                {
                    scores[A[i][0]] = new List<decimal> { Convert.ToDecimal(A[i][1]) };
                }
            }
            decimal maxAvg = 0;
            foreach (var item in scores)
            {
                var sum = item.Value.Sum();
                var avg = sum / item.Value.Count;
                if (avg > maxAvg) maxAvg = avg;
            }
            return (int)Math.Floor(maxAvg);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(HighestScore(new List<List<string>>
            {
                //new List<string>{ "A", "80"},
                //new List<string>{ "A", "90"},
                //new List<string>{ "C", "90"},
                //new List<string>{ "C", "10"}

                new List<string>{"fqyh","79"},
                new List<string>{"fqyh","12"},
                new List<string>{"fqyh","46"},
                new List<string>{"fqyh","45"},
                new List<string>{"fqyh","20"},
                new List<string>{"fqyh","10"},
                new List<string>{"fqyh","92"},
                new List<string>{"fqyh","93"},
                new List<string>{"fqyh","72"},
                new List<string>{"fqyh","53"},
                new List<string>{"fqyh","39"},
                new List<string>{"fqyh","99"},
                new List<string>{"fqyh","52"},
                new List<string>{"fqyh","59"}
            }));
        }
    }
}
