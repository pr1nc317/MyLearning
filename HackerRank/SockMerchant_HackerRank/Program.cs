using System.Collections.Generic;
using System.Linq;

namespace SockMerchant_HackerRank
{
    class Program
    {
        static int SockMerchant(int n, int[] ar)
        {
            int count = 0;
            List<int> li = new List<int>();
            for (int i = 0; i < ar.Count(); i++)
            {
                if (li.Contains(ar[i]))
                {
                    continue;
                }
                li.Add(ar[i]);
                int j = i + 1;
                int instance = 1;
                while (j < ar.Count() && j != ar.Length)
                {
                    if (ar[i] == ar[j])
                    {
                        instance++;
                    }
                    j++;
                }
                count = count + (instance / 2);
            }
            return count;
        }
        static void Main(string[] args)
        {
            int output = SockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
        }
    }
}
