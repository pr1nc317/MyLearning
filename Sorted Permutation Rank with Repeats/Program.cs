namespace Sorted_Permutation_Rank_with_Repeats
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int FindRank(string A)
        {
            #region Self Try -- failing due to factorial calculation
            //int length = A.Length;
            //int mod = 1000003;
            //long[] fact = new long[52];
            //fact[1] = 1;
            //for (int i = 2; i < 52; i++)
            //{
            //    fact[i] = (i * fact[i - 1]) % mod;
            //}
            //var ans = 0L;
            //var sorted = A.OrderBy(x => x).ToList();
            //var sortedSet = new SortedSet<char>(sorted);
            //var repeatedHash = new Dictionary<char, int>();
            //foreach (var item in sorted)
            //{
            //    if (repeatedHash.ContainsKey(item))
            //    {
            //        repeatedHash[item]++;
            //    }
            //    else repeatedHash[item] = 1;
            //}
            //string word = "";
            //for (int i = 0; i < length; i++)
            //{
            //    if (i > 0)
            //    {
            //        word += A[i - 1];
            //        repeatedHash[A[i - 1]]--;
            //    }
            //    for (int j = 0; j < sortedSet.Count && sortedSet.ElementAt(j) != A[i]; j++)
            //    {
            //        var interimAns = 0L;
            //        var interimWord = sortedSet.ElementAt(j);
            //        repeatedHash[interimWord]--;
            //        var duplicates = repeatedHash.Values.Where(x => x > 1);
            //        interimAns = fact[sorted.Count - 1];
            //        foreach (var item in duplicates)
            //        {
            //            interimAns /= fact[item];
            //        }
            //        repeatedHash[interimWord]++;
            //        ans += interimAns;
            //    }
            //    sorted.Remove(A[i]);
            //    var zeroValues = sortedSet.Where(x => !sorted.Contains(x)).ToList();
            //    foreach (var item in zeroValues)
            //    {
            //        sortedSet.Remove(item);
            //    }
            //}
            //return (int) ans + 1;
            #endregion

            #region IB Solution - using inverse factorial
            var alphabet = new List<char>();
            var permutationsOnLastStep = 1L;
            var rank = 0L;
            for (var i = A.Length - 1; i >= 0; i--)
            {
                var res = addChar(alphabet, A[i]);
                rank = (rank + permutationsOnLastStep * res[0] * inverse(res[1], 1000003)) % 1000003;
                permutationsOnLastStep = (permutationsOnLastStep * (A.Length - i) * inverse(res[1], 1000003)) % 1000003;
            }

            return (int)((rank + 1) % 1000003);

        }

        private static int[] addChar(List<char> alphabet, char ch)
        {
            var idxToInsert = 0;
            var numOfRepetions = 1;
            for (var i = 0; i < alphabet.Count; i++)
            {
                if (alphabet[i] < ch)
                {
                    idxToInsert = i + 1;
                }
                else if (alphabet[i] == ch)
                {
                    numOfRepetions++;
                }
                else
                {
                    break;
                }
            }
            alphabet.Insert(idxToInsert, ch);
            return new[] { idxToInsert, numOfRepetions };
        }

        // computing x^y % m
        private static long power(long x, long y, long m)
        {
            if (y == 0) return 1;
            var p = power(x, y / 2, m) % m;
            p = (p * p) % m;
            return (y % 2 == 0) ? p : (x * p) % m;
        }

        private static long inverse(long x, long m)
        {
            return power(x, m - 2, m);
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine(FindRank("sadasdsasassasas"));
            //Console.WriteLine(FindRank("SUCCESS"));
        }
    }
}
