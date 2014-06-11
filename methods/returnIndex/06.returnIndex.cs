using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace returnIndex
{
    class returnIndex
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 9, 2, 6, 1, 3, 3, 39, 5, 5, 5, 5 };
            Console.Write("Enter integer between 0 and {0}.\ninteger: ", arr.Length - 1);
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine("If is bigger than it's neighbors index appear else \"-1\". \nResult: {0}.", NeighborComparison(digit, arr));
        }
        static int NeighborComparison(int index, int[] array)
        {
            int isBigger = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (index == 0)
                {
                    if (array[index] > array[1])
                    {
                        isBigger = index;
                    }
                }
                else if (index == array.Length - 1)
                {
                    if (array[index] > array[array.Length - 1])
                    {
                        isBigger = index;
                    }
                }
                else if (index != 0 && index < array.Length)
                {
                    if (array[index] > array[index - 1] && array[index] > array[index + 1])
                    {
                        isBigger = index;
                    }
                }
                else
                {
                    isBigger = -1;
                }
            }
            return isBigger;
        }
    }
}
