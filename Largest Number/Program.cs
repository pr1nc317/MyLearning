namespace Largest_Number
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static string LargestNumber(List<int> A)
        {
            string ans = string.Empty;
            var list = A.ConvertAll<string>(x => { return x.ToString(); });
            list.Sort(CustomComparer);
            for(int i =0; i<A.Count; i++)
            {
                ans += list[i];
            }
            if (ans[0] == '0' && ans.Length > 1) return "0";
            return ans;
        }

        public static int CustomComparer(string x, string y)
        {
            string xy = x + y;
            string yx = y + x;
            return xy.CompareTo(yx) > 0 ? -1 : 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LargestNumber(new List<int> { 813, 696, 751, 718, 303, 947, 67, 633, 821, 587, 907, 331, 193, 667, 99, 496, 619, 841, 339, 981, 908, 576, 832, 491, 574, 899, 875, 871, 594, 672, 708, 931, 237, 587, 224, 638, 485, 102, 475, 281, 722, 77, 903, 386, 263, 652  }));
        }
    }
}