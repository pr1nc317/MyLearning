namespace Largest_Rectangle_In_Histogram
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public class IndexAndValue
        {
            public int index;
            public int value;
            public IndexAndValue(int ind, int val) { index = ind; value = val; }
        }

        public static int LargestRectangleArea(List<int> A)
        {
            // https://www.youtube.com/watch?v=zx5Sw9130L0&ab_channel=NeetCode
            #region Appraoch 1 - Using single stack
            //Stack<IndexAndValue> stack = new Stack<IndexAndValue>();
            //int maxArea = 0;
            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (stack.Count == 0)
            //    {
            //        stack.Push(new IndexAndValue(i, A[i]));
            //        continue;
            //    }
            //    if (stack.Peek().value <= A[i])
            //    {
            //        stack.Push(new IndexAndValue(i, A[i])); continue;
            //    }
            //    else
            //    {
            //        int index = 0;
            //        while (stack.Count > 0 && stack.Peek().value > A[i])
            //        {
            //            var popEle = stack.Pop();
            //            var width = i - popEle.index;
            //            var area = width * popEle.value;
            //            maxArea = Math.Max(maxArea, area);
            //            index = popEle.index;
            //        }
            //        stack.Push(new IndexAndValue(index, A[i]));
            //    }
            //}
            //while (stack.Count > 0)
            //{
            //    var popEle = stack.Pop();
            //    maxArea = Math.Max(maxArea, (A.Count - popEle.index) * popEle.value);
            //}
            //return maxArea;
            #endregion
            #region Appraoch 2 - Find Smaller element on right side and left side separately, then calculate area
            int[] left = LeftSmallerElement(A);
            int[] right = RightSmallerElement(A);
            int maxArea = 0;
            for (int i = 0; i < A.Count; i++)
            {
                maxArea = Math.Max(maxArea, (right[i] - left[i] - 1) * A[i]);
            }
            return maxArea;
            #endregion
        }

        public static int[] LeftSmallerElement(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            int[] res = new int[A.Count];
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count > 0 && A[stack.Peek()] >= A[i])
                    stack.Pop();
                if (stack.Count == 0)
                    res[i] = -1;
                else res[i] = stack.Peek();
                stack.Push(i);
            }
            return res;
        }

        public static int[] RightSmallerElement(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            int[] res = new int[A.Count];
            for (int i = A.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && A[stack.Peek()] >= A[i])
                    stack.Pop();
                if (stack.Count == 0)
                    res[i] = A.Count;
                else res[i] = stack.Peek();
                stack.Push(i);
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LargestRectangleArea(new List<int> { 2, 1, 5, 6, 2, 3 }));
            Console.WriteLine(LargestRectangleArea(new List<int> { 2 }));
        }
    }
}
