namespace _1342_Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    using System;

    class Program
    {
        static int NumberOfSteps(int num)
        {
            int ans = 0;
            while (num != 0)
            {
                if (num % 2 == 0) num /= 2;
                else num -= 1;
                ans++;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSteps(123));
        }
    }
}
