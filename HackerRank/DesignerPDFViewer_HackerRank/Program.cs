namespace DesignerPDFViewer_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Result
    {

        /*
         * Complete the 'designerPdfViewer' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY h
         *  2. STRING word
         */

        public static int DesignerPdfViewer(List<int> h, string word)
        {
            return word.ToCharArray().Select(character => (byte)character-97).Select(x=> h[x]).Max()*word.Length;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();
            string word = Console.ReadLine();
            int result = Result.DesignerPdfViewer(h, word);
        }
    }
}
