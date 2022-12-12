namespace Valid_Password
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            if (A.Length < 8 || A.Length > 15) return 0;
            bool zeroToNine = false;
            bool smallChar = false;
            bool bigChar = false;
            bool specialChar = false;
            foreach (var item in A)
            {
                if (char.IsDigit(item)) zeroToNine = true;
                if (item - 'a' >= 0 && item - 'a' < 26) smallChar = true;
                if (item - 'A' >= 0 && item - 'A' < 26) bigChar = true;
                if (item == '!' || item == '@' || item == '#' || item == '$' || item == '%' || item == '&' || item == '*')
                    specialChar = true;
            }
            return zeroToNine & smallChar & bigChar & specialChar ? 1 : 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("uok9$mpc"));
        }
    }
}
