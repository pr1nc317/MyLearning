namespace Which_Season
{
    using System;

    class Program
    {
        public static string Solve(int A)
        {
            if (A > 12 || A < 1) return "Invalid";
            A %= 13;
            if (A >= 3 && A <= 5) return "Spring";
            else if (A >= 6 && A <= 8) return "Summer";
            else if (A >= 9 && A <= 11) return "Autumn";
            //else if (A >= 12 && A <= 2) return "Winter";
            else return "Winter";
        }
        static void Main(string[] args)
        {
            /*
             Spring – March to May
             Summer – June to August
             Autumn – September to November
             Winter – December to February
             */
            Console.WriteLine(Solve(1));
        }
    }
}
