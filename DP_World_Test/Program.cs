namespace DP_World_Test
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        // input = "Ankit Sh@rma";
        // output = amrhS ti@knA

        static void Main(string[] args)
        {
            var input = "Am1t Sh@rma";
            Console.WriteLine(Reverse(input));
        }

        static string Reverse(string input)
        {
            string output = string.Empty;
            var array = input.ToCharArray();
            char[] result = new char[array.Length];
            // Inserting special characters in a special array
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < 65 || array[i] > 90) && (array[i] < 97 || array[i] > 122))
                {
                    result[i] = array[i];
                }
            }

            //Reverse of string
            int index = 1;
            int j = 0;
            while(index <= array.Length && j >= 0)
            {
                if ((array[array.Length - index] < 65 || array[array.Length - index] > 90) 
                    && (array[array.Length - index] < 97 || array[array.Length - index] > 122))
                {
                    if (result[j] != 0)
                    {
                        index++; j++; continue;
                    }
                    else
                    {
                        index++;
                        continue;
                    }
                }
                else if ((array[array.Length - index] >= 65 || array[array.Length - index] <= 90)
                    && (array[array.Length - index] >= 97 || array[array.Length - index] <= 122))
                {
                    if (result[j] != 0)
                    {
                        j++; continue;
                    }
                    else
                    {
                        result[j] = array[array.Length - index];
                    }
                }
                index++;
                j++;
            }
            output = string.Join(null, result);
            return output;
        }
    }
}
