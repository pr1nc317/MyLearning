namespace Rearrange_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> RearrangeArray(List<int> A)
        {
            /*
            Approach: The array elements of the given array lies from 0 to n-1. Now an array element is needed that can store two different values at the same time.
            To achieve this increment every element at ith index is incremented by (arr[arr[i]] % n)*n.
            After the increment operation of first step, every element holds both old values and new values. 
            Old value can be obtained by arr[i]%n and a new value can be obtained by arr[i]/n.

            How this can be achieved? 
            Let’s assume an element is a and another element is b, both the elements are less than n. 
            So if an element a is incremented by b*n. So the element becomes a + b*n so when a + b*n is divided by n then the value is b and a + b*n % n is a.

            Algorithm:  

            1. Traverse the array from start to end.
            2. For every index increment the element by array[array[index] ] % n. To get the ith element find the modulo with n, i.e array[index]%n.
            3. Again Travsese the array from start to end
            4. Print the ith element after dividing the ith element by n, i.e. array[i]/n.
            */

            for (int i = 0; i < A.Count; i++)
            {
                A[i] += (A[A[i]] % A.Count )*A.Count;
            }
            for (int i = 0; i < A.Count; i++)
            {
                A[i] /= A.Count;
            }

            return A;
        }

        static void Main(string[] args)
        {
            RearrangeArray(new List<int> { 4, 0, 2, 1, 3 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
