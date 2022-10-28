namespace Leap_Year
{
    using System;

    class Program
    {
        public static int IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(2000));
        }
    }
}
