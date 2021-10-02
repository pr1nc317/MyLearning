using System;

namespace PowerFunctionWithoutUsingMultiplication_Microsoft_Interview
{
    class Program
    {
        /// <Summary>
        /// This method computes 'n' raised to power 'm' without using '*' operator or 'pow' in-built method of 'Math' class
        /// </Summary>
        static int Pow(int num, int increment)
        {
            if (increment == 0)
            {
                return 1;
            }
            if (increment == 1)
            {
                return num;
            }
            else
            {
                int sum = num, toAdd = num;
                for (int i = 1; i < increment; i++)
                {
                    for (int j = 1; j < num; j++)
                    {
                        sum += toAdd;
                    }
                    toAdd = sum;
                }
                return sum;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number: ");
            var isNumberTrue = int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("Enter the power: ");
            var isPowerTrue = int.TryParse(Console.ReadLine(), out int power);
            if (isNumberTrue == true && isPowerTrue == true)
            {
                var result = Pow(number, power);
                Console.WriteLine(result);
            }
        }
    }
}
