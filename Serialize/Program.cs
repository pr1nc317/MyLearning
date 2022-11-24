namespace Serialize
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        public static string Serialize(List<string> A)
        {
            StringBuilder strbld = new StringBuilder();
            foreach (var item in A)
            {
                strbld.Append(item + item.Length + "~");
            }
            return strbld.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Serialize(new List<string> { "scaler", "academy" }));
        }
    }
}
