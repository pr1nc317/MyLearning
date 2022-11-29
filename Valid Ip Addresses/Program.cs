namespace Valid_Ip_Addresses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<string> RestoreIpAddresses(string A)
        {
            var validIps = new List<string>();
            if (A.Length <= 3) return validIps;

            for (int i = 1; i < 4 && i < A.Length; i++)
            {
                var first = A.Substring(0, i);
                if (IsValid(first))
                {
                    for (int j = 1; j < 4 && i + j < A.Length; j++)
                    {
                        var second = A.Substring(i, j);
                        if (IsValid(second))
                        {
                            for (int k = 1; k < 4 && i + j + k < A.Length; k++)
                            {
                                var third = A.Substring(i + j, k);
                                var fourth = A.Substring(i + j + k);
                                if (IsValid(third) && IsValid(fourth))
                                {
                                    validIps.Add(first + "." + second + "." + third + "." + fourth);
                                }
                            }
                        }
                    }
                }
            }
            return validIps;
        }

        public static bool IsValid(string ip)
        {
            if (ip.Length == 0 || ip.Length > 3) return false;
            if (ip[0] == '0' && ip.Length > 1) return false;
            var value = Convert.ToInt32(ip);
            return value >= 0 && value < 256;
        }

        static void Main(string[] args)
        {
            //RestoreIpAddresses("01010").ForEach(x => Console.WriteLine(x));
            //RestoreIpAddresses("25525511135").ForEach(x => Console.WriteLine(x));
            //RestoreIpAddresses("255255111256").ForEach(x => Console.WriteLine(x));
            //RestoreIpAddresses("1112222").ForEach(x => Console.WriteLine(x));
            RestoreIpAddresses("0100100").ForEach(x => Console.WriteLine(x));
        }
    }
}
