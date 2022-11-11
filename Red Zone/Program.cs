namespace Red_Zone
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<List<int>> A, int B)
        {
            List<Coordinates> list = new List<Coordinates>();
            foreach (var item in A)
            {
                list.Add(new Coordinates(item[0], item[1]));
            }
            long start = 0;
            long end = 2000000000;
            long res = int.MaxValue;
            while (start <= end)
            {
                long mid = (start + end) / 2;
                if (Check(list, B, mid))
                {
                    end = mid - 1;
                    res = Math.Min(mid, res);
                }
                else start = mid + 1;
            }
            return (int)start;
        }

        public class Coordinates
        {
            public double row;
            public double col;

            public Coordinates(double row, double col)
            {
                this.row = row;
                this.col = col;
            }

            public double Absolute()
            {
                return Math.Sqrt((this.row * this.row) + (this.col * this.col));
            }

            public Coordinates Add(Coordinates C)
            {
                return new Coordinates(this.row + C.row, this.col + C.col);
            }

            public Coordinates Subtract(Coordinates C)
            {
                return new Coordinates(this.row - C.row, this.col - C.col);
            }
        }

        public static bool Check(List<Coordinates> list, int B, long mid)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    Coordinates r2Minusr1 = list[j].Subtract(list[i]);
                    var dist = r2Minusr1.Absolute();
                    if (dist > 2*mid)
                    {
                        continue;
                    }
                    Coordinates middle = list[j].Add(list[i]);
                    middle.row /= 2; middle.col /= 2;
                    double height = Math.Sqrt((mid * mid) - ((dist * dist) / 4));
                    Coordinates perpendicular = new Coordinates((r2Minusr1.col * (height / dist)), -(r2Minusr1.row * (height / dist)));
                    int x = 2; int y = 2;
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (k == i || k == j)
                        {
                            continue;
                        }
                        if (middle.Add(perpendicular).Subtract(list[k]).Absolute() <= mid)
                        {
                            x++;
                        }
                        if (middle.Subtract(perpendicular).Subtract(list[k]).Absolute() <= mid)
                        {
                            y++;
                        }
                    }
                    count = Math.Max(count, Math.Max(x, y));
                }
            }
            return count >= B;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<List<int>> {
                new List<int> { 8, 5 },
                new List<int> { 0, 4 },
                new List<int> { 3, 6 }
            }, 3));
            Console.WriteLine(Solve(new List<List<int>> {
                new List<int> { 2, 3 },
                new List<int> { 9, 4 },
                new List<int> { 10, 3 }
            }, 2));
            Console.WriteLine(Solve(new List<List<int>>
            {
                new List<int> {762888, 842056},
                new List<int> {943296, 205226},
                new List<int> {528530, 840859},
                new List<int> {490975, 305681},
                new List<int> {784949, 795242},
                new List<int> {364631, 24977},
                new List<int> {335193, 566499},
                new List<int> {175628, 435361},
                new List<int> {394134, 454625},
                new List<int> {130339, 131963},
                new List<int> {62547, 401942},
                new List<int> {101919, 622627},
                new List<int> {667354, 263679},
                new List<int> {704772, 951888},
                new List<int> {183983, 927405},
                new List<int> {192090, 610510},
                new List<int> {573528, 118235},
                new List<int> {156736, 580620},
                new List<int> {507137, 194840},
                new List<int> {665701, 508127},
                new List<int> {26162, 42107}
            }, 20));
        }
    }
}
