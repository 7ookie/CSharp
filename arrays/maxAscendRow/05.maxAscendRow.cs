using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maxAscendRow
{
    class maxAscendRow
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter integer number to set array lenght.");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            int len = 1;
            int start = 0;
            int bestLen = 0;
            int bestStart = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    len += 1;
                    start = array[i] + 2 - len;
                }
                else
                {
                    len = 1;
                    start = 0;
                }
                if (bestLen < len)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            Console.Write("The maximal row of ascending array elements is: {");
            while (bestLen != 0)
            {
                Console.Write("{0}", bestStart);
                bestLen--;
                bestStart++;
                if (bestLen > 0)
                {
                    Console.Write(", ");
                }
            }
            if (bestLen == 0)
            {
                Console.Write("}");
            }
            Console.WriteLine();
        }
    }
}
