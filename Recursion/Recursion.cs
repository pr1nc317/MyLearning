using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {
        static int ComputeFactorial(int a)
        {
            if (a < 1)
                return 1;
            else
                return a * ComputeFactorial(a - 1);
        }
        static void Main(string[] args)
        {
            var output = ComputeFactorial(5);
            Console.WriteLine("Factorial: " + output);
        }
    }
}
