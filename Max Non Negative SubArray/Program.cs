namespace Max_Non_Negative_SubArray
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<long> Maxset(List<long> A)
        {
            int index = 0;
            long lastSum = 0;
            List<long> resultantArray = new List<long>();
            while (index < A.Count)
            {
                List<long> B = new List<long>();
                long currentSum = 0;
                while (index < A.Count && A[index] >= 0)
                {
                    B.Add(A[index]);
                    index++;
                }
                for (int i = 0; i < B.Count; i++)
                {
                    currentSum += B[i];
                }
                if (lastSum < currentSum)
                {
                    lastSum = currentSum;
                    resultantArray = B;
                }
                else if (lastSum == currentSum)
                {
                    if (resultantArray.Count >= B.Count)
                        resultantArray = resultantArray;
                    else
                        resultantArray = B;                
                }
                index++;
            }
            return resultantArray;
        }

        static void Main(string[] args)
        {
            var result = Maxset(new List<long> { 1967513926, 1540383426, -1303455736, -521595368 });
            foreach (var item in result)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
