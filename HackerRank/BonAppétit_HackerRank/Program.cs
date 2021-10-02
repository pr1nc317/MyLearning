using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppétit_HackerRank
{
    class Program
    {
        static void BonAppetit(List<int> bill, int k, int b)
        {
            int temp = bill[k];
            bill.Remove(bill[k]);
            int eachShare = bill.Sum()/2;
            if (eachShare == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else Console.WriteLine(b - eachShare);
        }
        static void Main(string[] args)
        {
            BonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 12);
        }
    }
}
