namespace DayOfTheProgrammer_HackerRank
{
    class Program
    {
        static string DayOfProgrammer(int year)
        {
            string result = null;
            if (year != 1918)
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) || (year < 1918 && year % 4 == 0))
                {
                    result = "12.09." + year;
                }
                else
                {
                    result = "13.09." + year;
                }
            }
            else if (year == 1918)
            {
                result = "26.09." + year;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string output = DayOfProgrammer(2100);
        }
    }
}
