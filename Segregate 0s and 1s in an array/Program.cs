namespace Segregate_0s_and_1s_in_an_array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> Segregate(List<int> A)
        {
            #region Solution 1 - Count 0s and 1s
            /*
             Method 1 (Count 0s or 1s) 
            Thanks to Naveen for suggesting this method. 
            1) Count the number of 0s. So let’s understand with an example we have an array arr = [0, 1, 0, 1, 0, 0, 1] 
            the size of the array is 7 now we will traverse the entire array and find out the number of zeros in the array.
            In this case the number of zeros is 4 so now we can easily get the number of Ones in the array by Array Length – Number Of Zeros.

            2) Once we have counted, we can fill the array first we will put the zeros and then ones (we can get number of ones by using above formula).
            Time Complexity : O(n) 
             */

            //int zeros = A.Count(x => x == 0);
            //int ones = A.Count - zeros;
            //var list1 = Enumerable.Repeat(0, zeros).ToList();
            //var list2 = Enumerable.Repeat(1, ones).ToList();
            //list1.AddRange(list2);
            //return list1;

            #endregion

            #region Solution 2 - Use two indexes to traverse
            /*
            (Use two indexes to traverse) 
            Maintain two indexes. Initialize the first index left as 0 and second index right as n-1.
            Do following while left < right 
            a) Keep incrementing index left while there are 0s at it 
            b) Keep decrementing index right while there are 1s at it 
            c) If left < right then exchange arr[left] and arr[right]
             */

            //int left = 0; int right = A.Count - 1;

            //while(left < right)
            //{
            //    while (A[left] == 0 && left < right)
            //        left++;

            //    while (A[right] == 1 && right > left)
            //        right--;

            //    if(left < right)
            //    {
            //        int temp = A[left];
            //        A[left] = 0;
            //        A[right] = 1;
            //        left++;
            //        right--;
            //    }
            //}
            //return A;

            #endregion

            #region Simple Solution with while loop
            
            int z = 0, i = 0;
            while (i < A.Count)
            {
                if (A[i] == 0)
                {
                    A[i] = A[z];
                    A[z] = 0;
                    z++;
                }
                i++;
            }
            return A;

            #endregion
        }

        static void Main(string[] args)
        {
            Segregate(new List<int> { 1,0,0,0,1,1,1,0,1,0,1}).ForEach(x => Console.Write(x + " "));
        }
    }
}
