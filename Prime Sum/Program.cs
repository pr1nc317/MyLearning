namespace Prime_Sum
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Primesum(int A)
        {
            // Find prime numbers using Sieve of Eratosthenes
            // Step 1 - Create an array of size A+1
            bool[] arr = new bool[A+1];
            for(int i =2; i <= A; i++)
            {
                arr[i] = true;
            }

            // Step 2 - Mark those numbers as false which are greater than equal to sqaures of every number
            for (int i = 2; i*i <= A; i++)
            {
                for (int j = i*i; j <= A; j+=i)
                {
                    arr[j] = false;
                }
            }

            // Step 3 - Traverse through the array and find the right combination
            var list = new List<int>();
            for (int i = 2, j = A-i; i <= arr.Length;)
            {
                if (!arr[i] && !arr[j])
                {
                    i++; j--;
                }
                else if (arr[i] && !arr[j])
                {
                    j--;
                }
                else if (!arr[i] && arr[j])
                {
                    i++;
                }
                else if (arr[i] && arr[j])
                {
                    if (i + j == A)
                    {
                        list.Add(i); list.Add(j); break;
                    }
                    if (i + j < A)
                    {
                        i++; continue;
                    }
                    if (i + j > A)
                    {
                        j--; continue;
                    }
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            Primesum(378).ForEach(x => Console.WriteLine(x));
        }
    }
}
