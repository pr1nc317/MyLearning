namespace Length_of_Last_Word
{
    using System;

    class Program
    {
        public static int LengthOfLastWord(string A)
        {
            bool firstAlphabetContacted = false;
            int count = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (firstAlphabetContacted)
                {
                    if (A[i] == 32) return count;
                    else count++;
                }
                else
                {
                    if (A[i] == 32) continue;
                    else
                    {
                        firstAlphabetContacted = true;
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello  "));
        }
    }
}
