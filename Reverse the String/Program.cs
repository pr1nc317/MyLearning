namespace Reverse_the_String
{
    using System;
    using System.Text;

    class Program
    {
        public static string Solve(string A)
        {
            StringBuilder sb = new StringBuilder();
            bool charContacted = false;
            int charContactedIndex = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (charContacted)
                {
                    if (A[i] == 32)
                    {
                        charContacted = false;
                        sb.Append(A.Substring(i + 1, charContactedIndex - i) + " ");
                    }
                }
                else
                {
                    if (A[i] != 32)
                    {
                        charContacted = true;
                        charContactedIndex = i;
                    }
                }
            }
            if (charContacted && charContactedIndex >= 0)
            {
                sb.Append(A.Substring(0, charContactedIndex + 1));
            }
            return sb.ToString().Trim();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(" a    Hello    World  "));
        }
    }
}
