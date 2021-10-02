using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndAMouse_HackerRank
{
    class Program
    {
        static string CatAndMouse(int x, int y, int z)
        {
            string res = null;
            if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                res = "Cat A";
            }
            else if (Math.Abs(z - x) > Math.Abs(z - y))
            {
                res = "Cat B";
            }
            else if (Math.Abs(z - x) == Math.Abs(z - y))
            {
                res = "Mouse C";
            }
            return res;
        }
        static void Main(string[] args)
        {
            string output = CatAndMouse(1, 2, 3);
        }
    }
}
