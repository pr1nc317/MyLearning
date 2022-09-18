namespace _1909_RemoveOneElementtoMaketheArrayStrictlyIncreasing
{
    using System;

    class Program
    {
        static bool CanBeIncreasing(int[] nums)
        {
            int error = 0; int index = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] >= nums[i])
                {
                    error++;
                    index = i;
                    if (error == 2) return false;
                }
            }
            if (index == 1 || index == nums.Length - 1) return true;
            if (error == 0) return true;
            else if (error == 1)
            {
                if (nums[index - 1] < nums[index + 1]) return true;
                else if (nums[index - 2] < nums[index]) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CanBeIncreasing(new int[] { 1, 2, 10, 11, 8, 14, 14 }));
        }
    }
}
