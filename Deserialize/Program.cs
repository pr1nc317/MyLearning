namespace Deserialize
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<string> Deserialize(string A)
        {
            //var arr = A.Split("~");
            var res = new List<string>();
            int startIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] >= 'a' && A[i] <='z') || (A[i] >= 'A' && A[i] <= 'Z'))
                {
                    if (startIndex == -1) 
                        startIndex = i;
                    continue;
                }
                else
                {
                    if (startIndex == -1)
                    {
                        continue;
                    }
                    res.Add(A.Substring(startIndex, i - startIndex));
                    startIndex = -1;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Deserialize("scaler6~academy7~").ForEach(x => Console.WriteLine(x));
            Deserialize("interviewbit12~").ForEach(x => Console.WriteLine(x));
        }
    }
}
