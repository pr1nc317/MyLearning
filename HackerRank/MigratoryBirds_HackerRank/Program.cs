using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds_HackerRank
{
    class Program
    {
        static int MigratoryBirds(List<int> arr)
        {
            int output = arr[0], maxCount = 0;
            List<int> processed = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (processed.Contains(arr[i]))
                {
                    continue;
                }
                processed.Add(arr[i]);

                int numcount = 0;
                int j = i;
                while (j < arr.Count)
                {
                    if (arr[i] == arr[j])
                    {
                        numcount++;
                    }
                    j++;
                }
                if (numcount > maxCount)
                {
                    maxCount = numcount;
                    output = arr[i];
                }
                else if (numcount == maxCount)
                {
                    output = Math.Min(arr[i], output);
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            int output = MigratoryBirds(new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 });
        }
    }
}
