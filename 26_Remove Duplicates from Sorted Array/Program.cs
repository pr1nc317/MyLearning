namespace _26_Remove_Duplicates_from_Sorted_Array
{
    using System;

    class Program
    {
        static int RemoveDuplicates(int[] nums)
        {
            int j = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
            Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 2 }));
        }
    }
}
