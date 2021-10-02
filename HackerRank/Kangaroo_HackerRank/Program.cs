using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo_HackerRank
{
    class Program
    {
        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            int destinationA = x1, destinationB = x2;
            for(int i = 0; destinationA<destinationB; i++)
            {
                destinationA += v1;
                destinationB += v2;
                if (destinationA == destinationB)
                {
                    return "YES";
                }
            }
            return "NO";
        }
        static void Main(string[] args)
        {
            string output = Kangaroo(0, 3, 4, 2);
        }
    }
}
