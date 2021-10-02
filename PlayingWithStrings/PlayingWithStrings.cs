using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithStrings
{
    class PlayingWithStrings
    {
        public enum ecuType { RDO, TCU };
        static void Main(string[] args)
        {
            #region String Formatting
            int x = 10;
            object y = x;
            y = 20;
            Console.WriteLine("{0},{1}", x);
            #endregion

            #region substring
            string a = "ABCDEFGHIJ";
            Console.WriteLine(a.Substring(0, 7));
            #endregion

            #region split
            string s = "Geeks, For Geeks";
            //string[] output = s.Split(new string[]{ "s, ", "For "}, 2, StringSplitOptions.RemoveEmptyEntries);
            string[] output = s.Split(new char[] {' '}, 4, StringSplitOptions.None);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------");

            #endregion

        }
    }
}