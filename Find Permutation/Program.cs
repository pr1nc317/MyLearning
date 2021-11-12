namespace Find_Permutation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int[] FindPermutation(string A, int B)
        {
            #region Solution 1 - using array
            //int[] arr = new int[B];
            //int start = 1;
            //int end = B;
            //int i;
            //for (i = 0; i < A.Length; i++)
            //{
            //    if(A[i] == 'I')
            //    {
            //        arr[i] = start++;
            //    }
            //    else
            //    {
            //        arr[i] = end--;
            //    }
            //}
            //arr[i] = start;
            //return arr;
            #endregion

            #region Solution 2 - using stack
            //Stack<int> stack = new Stack<int>();
            //var ans = new List<int>();
            //int i;
            //for (i = 0; i < A.Length; i++)
            //{
            //    stack.Push(i);
            //    if (A[i] == 'I')
            //    {
            //        while(stack.Count > 0)
            //        {
            //            ans.Add(stack.Pop());
            //        }
            //    }
            //}

            //stack.Push(i);

            //while (stack.Count > 0)
            //{
            //    ans.Add(stack.Pop());
            //}

            //return ans.ToArray();
            #endregion

            #region Solution 3 - using simple variables
            int i, j, start = 1, end = 0;
            var ans = new List<int>();
            for (i = 0; i < A.Length; i++)
            {
                end++;
                if (A[i] == 'I')
                {
                    for (j = end; j >= start; j--)
                    {
                        ans.Add(j);
                    }
                    start = end + 1;
                }
            }
            
            ans.Add(end + 1);

            for (j = end; j >= start; j--)
            {
                ans.Add(A[j]);
            }

            return ans.ToArray();
            #endregion
        }

        static void Main(string[] args)
        {
            var ans = FindPermutation("IDI", 4);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
