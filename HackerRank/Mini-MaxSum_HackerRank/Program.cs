using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "1";
            do
            {
                long minsum = 0;
                long maxsum = 0;
                long[] arr = new long[5];
                for (int i = 0; i < 5; i++)
                {
                    long num = Convert.ToInt64(Console.ReadLine());
                    arr[i] = num;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            long temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                Int64[] array = new Int64[5];
                Array.Sort(array);
                Console.Write("ARRAY:\n");
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
                for (int i = 0; i < arr.Length-1; i++)
                {
                    minsum += arr[i];
                }
                for (int i = 1; i < arr.Length; i++)
                {
                    maxsum += arr[i];
                }
                
                Console.WriteLine("minsum = {0}\nmaxsum = {1}\nWant to Continue??? \t 1.Yes \t 2.No", minsum, maxsum);
                option = Console.ReadLine();
            } while (option=="1");
            
        }
    }
}
