namespace _35_SearchInsertPosition
{
    using System;

    class Program
    {
        static int SearchInsert(int[] nums, int target)
        {
            // Binary Search
            int low = 0;
            int high = nums.Length - 1;
            int mid;

            // base conditions
            if (target < nums[0]) return 0;
            if (target > nums[nums.Length - 1]) return nums.Length;

            while (high - low > 1)
            {
                mid = (high + low) / 2;
                if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else high = mid;
            }
            if (nums[low] >= target) return low;
            else return high;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsert(new int[] { 3, 5, 7, 9, 10 }, 8));
        }
    }
}
