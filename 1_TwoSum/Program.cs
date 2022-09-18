namespace _1_TwoSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            List<int> list = new List<int>(); int a = 0, b = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(target - nums[i]))
                {
                    list.Add(nums[i]);
                    continue;
                }
                a = i; b = list.IndexOf(target - nums[i]);
            }
            return new int[] { a, b };
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new int[] { 2, 10, 8, 7, 1 }, 9));
        }
    }
}
