namespace Two_Stores
{
    using System;

    class Program
    {
        public static int Solve(int A, int B, int C, int D, int E)
        {
            int cost = 0;
            int cheapStoreCandyCount;
            int cheapStoreCandyPrice;
            int costlyStoreCandyCount;
            int costlyStoreCandyPrice;
            decimal store1PriceFor1Candy = (decimal)C / (decimal)B;
            decimal store2PriceFor1Candy = (decimal)E / (decimal)D;
            if (store1PriceFor1Candy < store2PriceFor1Candy)
            {
                cheapStoreCandyCount = B;
                cheapStoreCandyPrice = C;
                costlyStoreCandyCount = D;
                costlyStoreCandyPrice = E;
            }
            else
            {
                cheapStoreCandyCount = D;
                cheapStoreCandyPrice = E;
                costlyStoreCandyCount = B;
                costlyStoreCandyPrice = C;
            }

            while (A % cheapStoreCandyCount != 0)
            {
                A = A - costlyStoreCandyCount;
                if (A < 0) return -1;
                cost += costlyStoreCandyPrice;
            }
            cost += (A / cheapStoreCandyCount) * cheapStoreCandyPrice;
            return cost;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(5, 3, 3, 3, 2));
            Console.WriteLine(Solve(7, 1, 1, 3, 2));
            Console.WriteLine(Solve(530, 7, 1, 4, 1));
        }
    }
}
