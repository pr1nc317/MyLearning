using System;
using System.Collections.Generic;

namespace PickingNumbers_HackerRank
{
    class Program
    {
        public static int PickingNumbers(List<int> a)
        {
            int size = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int count = 0, countPlusOne = 0, countMinusOne = 0;
                for (int j = 0; j < a.Count; j++)
                {
                    if (a[i] - a[j] == -1) countPlusOne++;
                    if(a[i] - a[j] == 1) countMinusOne++;
                    if (a[i] == a[j])
                    {
                        countMinusOne++;
                        countPlusOne++;
                    }
                }
                if (countMinusOne < countPlusOne) count = countPlusOne;
                else count = countMinusOne;
                if (size < count) size = count;
            }
            return size;
        }
        static void Main(string[] args)
        {
            int output = PickingNumbers(new List<int>() { 1, 2, 2, 3, 1, 2 });
        }
    }
}