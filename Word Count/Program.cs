namespace Word_Count
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            int count = 0; bool charSeen = false;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == ' ' && charSeen)
                {
                    count++;
                    charSeen = false;
                }
                else if (A[i] != ' ')
                {
                    charSeen = true;
                }
            }
            if (charSeen)
            {
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("    "));
        }
    }
}
