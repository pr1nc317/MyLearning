using System;

namespace TimeConversion_HackerRank
{
    class Program
    {
        public static string TimeConversion(string s)
        {
            string[] a = s.Split(':');
            string militaryTime = null;
            if (a[2].Contains("AM"))
            {
                if (a[0] == "12")
                {
                    militaryTime = "00:" + a[1] + ":" + a[2].Substring(0,2);
                }
                else
                {
                    militaryTime = a[0] + ":" + a[1] + ":" + a[2].Substring(0, 2);

                }
            }
            else
            {
                if (a[0] == "12")
                {
                    militaryTime = (Convert.ToInt32(a[0])) + ":" + a[1] + ":" + a[2].Substring(0, 2);
                }
                else
                {
                    militaryTime = (Convert.ToInt32(a[0]) + 12) + ":" + a[1] + ":" + a[2].Substring(0, 2);
                }
            }
            return militaryTime;
        }

        static void Main(string[] args)
        {
            string a = TimeConversion("12:00:00AM");
            Console.WriteLine(a);
        }
    }
}
