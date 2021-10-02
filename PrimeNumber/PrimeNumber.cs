using System;

namespace PrimeNumber

{
    class PrimeNumbers
    {
        private static bool IsPrime(int input)
        {
            try
            {
                if (input < 2)
                    throw new IndexOutOfRangeException();
                else
                {
                    int count = 0, num = 1;
                    while (num <= input)
                    {
                        if (input % num == 0)
                            count++;
                        num++;
                    };
                    if (count == 2)
                        return true;
                    else return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static void Main(string[] args)
        {           
            char[] option = { '1' };
            do
            {
                //input number from user
                Console.Write("Input Number to determine whether a prime number or not! : ");
                int input = Convert.ToInt32(Console.ReadLine());

                //method to find out whether prime or not
                bool result = IsPrime(input);

                //display result
                if (result == true)
                    Console.WriteLine(input + " is a prime number.\n");
                else
                    Console.WriteLine(input + " isn't a prime number.\n");
                Console.Write("Do you want to continue finding prime numbers?\nPress 1 for Yes, Press any other key to exit: ");
                option = Console.ReadLine().ToCharArray();
                Console.WriteLine();
            } while (option[0].Equals('1'));
        }
    }
}