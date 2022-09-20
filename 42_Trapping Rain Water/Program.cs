namespace _42_Trapping_Rain_Water
{
    using System;
    using System.Collections;

    class Program
    {
        static int Trap(int[] height)
        {
            #region Method 1 - O(N^2)-O(1) - Brute Force
            // at each index (except first and last index) - calculate the left_max and right_max
            // take minimum of left_max and right_max, then subtract it from height[i]

            //int ans = 0;
            //for (int i = 1; i < height.Length - 1; i++)
            //{
            //    int left_max = 0; int right_max = 0;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (height[j] > left_max)
            //        {
            //            left_max = height[j];
            //        }
            //    }

            //    for (int j = i + 1; j < height.Length; j++)
            //    {
            //        if (height[j] > right_max)
            //        {
            //            right_max = height[j];
            //        }
            //    }
            //    ans += Math.Min(right_max, left_max) - height[i] >= 0 ? Math.Min(right_max, left_max) - height[i] : 0;
            //}
            //return ans;
            #endregion

            #region Method 2 - O(N)-O(2N) - Array pre-processing
            // maintain two arrays - each for left max and right max (which was calculated in each loop in method 1)
            // this will save time as we are pre-processingn the array but will increase space

            //var left_max = new int[height.Length];
            //var right_max = new int[height.Length];
            //int leftMax = 0; int rightMax = 0; int ans = 0;
            //for (int i = 0, j = height.Length - 1; i < height.Length; i++, j--)
            //{
            //    if (height[i] > leftMax)
            //    {
            //        leftMax = height[i];
            //    }
            //    left_max[i] = leftMax;
            //    if (height[j] > rightMax)
            //    {
            //        rightMax = height[j];
            //    }
            //    right_max[j] = rightMax;
            //}

            //for (int i = 0; i < height.Length; i++)
            //{
            //    ans += Math.Min(left_max[i], right_max[i]) - height[i];
            //}
            //return ans;
            #endregion

            #region Method 3 - O(N)-O(N) - Using Stack
            //int ans = 0;
            //var stack = new Stack();
            //for (int i = 0; i < height.Length; i++)
            //{
            //    while (stack.Count != 0 && height[i] > height[(int)stack.Peek()])
            //    {
            //        int pop_ht = height[(int)stack.Pop()];
            //        if (stack.Count == 0) break;
            //        int distance = i - (int)stack.Peek() - 1;
            //        int ht = Math.Min(height[i], height[(int)stack.Peek()]) - pop_ht;
            //        ans += distance * ht;
            //    }
            //    stack.Push(i);
            //}
            //return ans;
            #endregion

            #region Method 4 - O(N)-O(1) - Using 2 Pointer Technique
            int ans = 0; int left_max = 0; int right_max = 0;
            int left = 0; int right = height.Length - 1;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] > left_max)
                    {
                        left_max = height[left];
                    }
                    else
                    {
                        ans += left_max - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] > right_max)
                    {
                        right_max = height[right];
                    }
                    else
                    {
                        ans += right_max - height[right];
                    }
                    right--;
                }
            }
            return ans;
            #endregion
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Trap(new int[] { 5, 4, 3, 5 }));
            Console.WriteLine(Trap(new int[] { 0, 2, 0 }));
            Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
            Console.WriteLine(Trap(new int[] { 4, 2, 0, 3, 2, 5 }));
        }
    }
}
