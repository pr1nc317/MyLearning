namespace _287_FindtheDuplicateNumber
{
    using System;

    class Program
    {
        #region Sort Array
        //static int DupNum(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int ans = 0;
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        if (nums[i] == nums[i + 1])
        //            ans = nums[i];
        //    }
        //    return ans;
        //}
        #endregion

        #region sum of first n natural numbers
        //static int DupNum(int[] nums)
        //{
        //    int sumOfNaturalNumbers = (nums.Length*(nums.Length - 1)) / 2;
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        sum += item;
        //    }
        //    return sum - sumOfNaturalNumbers;
        //}
        #endregion

        #region Negative Marking
        //static int DupNum(int[] nums)
        //{
        //    int[] arr = new int[nums.Length];
        //    int ans = 0;
        //    foreach (var item in nums)
        //    {
        //        if (arr[item] == 0) arr[item] = -1;
        //        else
        //        {
        //            ans = item;
        //            break;
        //        }
        //    }
        //    return ans;
        //}
        #endregion

        #region nums[nums[i] % nums.Length] += nums.Length;
        //static int DupNum(int[] nums)
        //{
        //    int ans = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        nums[nums[i] % nums.Length] += nums.Length;
        //    }

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] >= 2 * nums.Length)
        //            ans = i;
        //    }
        //    return ans;
        //}
        #endregion

        /*
         * STEPS:
         * 1. Take a slow pointer and a fast pointer. Initialize them with 0. Shift slow pointer by 1 step and fast pointer by 2 steps. 
         * Stop the process when both are at the same node. 
         * 2. Then while keeping the first slow pointer at its position, introduce another slow pointer, lets say Slow2. 
         * Initialize it also with 0. Now move the old slow pointer and the new slow pointer by 1 step each until they intersect. 
         * This point of intersection is the answer which is getting repeated.
         */
        #region Floyd's Tortoise and Hare (Cycle Detection)
        static int DupNum(int[] nums)
        {
            int slow = 0;
            int fast = 0;
            while (true)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (slow == fast)
                    break;
            }
            int slow2 = 0;
            while (true)
            {
                slow = nums[slow];
                slow2 = nums[slow2];
                if (slow == slow2)
                    break;
            }
            return slow;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine(DupNum(new int[] { 1, 3, 4, 2, 2 }));
        }
    }
}