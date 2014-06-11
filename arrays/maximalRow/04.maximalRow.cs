using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maximalRow
{
    class maximalRow
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
            //int[] array = { 2, 1, 1, 2, 3, 3, 3, 3, 2, 2, 2, 1 };
            int len = 1;
            int start = 0;
            int bestLen = 0;
            int bestStart = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    len += 1;
                    start = array[i];
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
            Console.Write("The maximal row of equal array elements is: {");
            while (bestLen != 0)
            {
                Console.Write("{0}", bestStart);
                bestLen--;
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
