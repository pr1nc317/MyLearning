namespace _628_MaximumProductofThreeNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        static int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int product = 0;
            //Default (last 3 values of sorted array)
            product = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];

            //last value * first 2 values(in case of negative)
            if (nums[0] < 0 && nums[1] < 0)
            {
                if (nums[nums.Length - 1] * nums[0] * nums[1] > product) product = nums[nums.Length - 1] * nums[0] * nums[1];
            }

            return product;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaximumProduct(new int[] { -1, -2, -3 }));
        }
    }
}
