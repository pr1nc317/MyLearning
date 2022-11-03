namespace Capacity_To_Ship_Packages_Within_B_Days
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // Time Complexity - O(n*log(sum-max)) where n is length of array 'a', sum is sum of array 'a' and max is the maximum element of array 'a'
        public static int Solve(List<int> a, int days)
        {
            int start = a.Max();
            int end = a.Sum();
            int ans = -1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (IsValid(a, days, mid))
                {
                    ans = mid;
                    end = mid - 1;
                }
                else start = mid + 1;
            }
            return ans;
        }

        public static bool IsValid(List<int> a, int days, int mid)
        {
            int sum = 0;
            int daysCount = 1;
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
                if (sum > mid)
                {
                    daysCount++;
                    sum = a[i];
                }
                if (daysCount > days)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5));
            Console.WriteLine(Solve(new List<int> { 3, 2, 2, 4, 1, 4 }, 3));
        }
    }
}
