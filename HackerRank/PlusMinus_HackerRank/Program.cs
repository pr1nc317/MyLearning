namespace PlusMinus_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        class Result
        {

            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void plusMinus(List<int> arr)
            {
                int positives = 0, zeroes = 0, negatives = 0; 
                foreach(var item in arr)
                {
                    _ = item > 0 ? positives++ : 1;
                    _ = item == 0 ? zeroes++ : 1;
                    _ = item < 0 ? negatives++ : 1;
                }
                Console.WriteLine(
                    ((decimal)positives / arr.Count).ToString("F6") + Environment.NewLine +
                    ((decimal)negatives / arr.Count).ToString("F6") + Environment.NewLine +
                    ((decimal)zeroes / arr.Count).ToString("F6"));
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                //int n = Convert.ToInt32(Console.ReadLine().Trim());
                //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                Result.plusMinus(new List<int> { 1,2,0,-1,-1});
            }
        }
    }
}
