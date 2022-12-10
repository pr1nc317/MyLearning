namespace Power_of_2
{
    using System;

    class Program
    {
        public static int Power(string A)
        {
            if (A == "1" || A == "0") return 0;
            var arr = A.ToCharArray();
            while (A.Length != 1 || A[A.Length - 1] != '1')
            {
                if (IsOdd(A))
                    return 0;
                int rem = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '0' && rem == 0) continue;
                    if (arr[i] == '1' && rem == 0)
                    {
                        rem = arr[i] - '0';
                        arr[i] = '0';
                        continue;
                    }
                    else
                    {
                        var dividend = rem * 10 + (arr[i] - '0');
                        var quotient =  dividend / 2;
                        arr[i] = quotient.ToString()[0];
                        rem = dividend % 2;
                    }
                }

                A = new string(arr);
                A = RemoveLeadingZeros(A);
            }
            
            return 1;
        }

        public static string RemoveLeadingZeros(string A)
        {
            int i = 0;
            while (A[i] - '0' == 0)
                i++;
            return A.Substring(i, A.Length - i);
        }

        public static bool IsOdd(string A)
        {
            var lastChar = A[A.Length - 1];
            if (lastChar == '2' || lastChar == '4' || lastChar == '6' || lastChar == '8') return false;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Power("13407807929942597099574024998205846127479365820592393377723561443721764030073546976801874298166903427690031858186486050853753882811946569946433649006084096"));
        }
    }
}