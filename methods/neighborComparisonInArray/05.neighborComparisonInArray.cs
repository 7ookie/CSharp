using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace neighborComparisonInArray
{
    class neighborComparisonInArray
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 5, 7, 9, 2, 6, 1, 3, 3, 39, 5, 5, 5, 5};
            Console.Write("Enter integer between 0 and {0}.\ninteger: ", arr.Length - 1);
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine("Is bigger than it's neighbors? \n{0}.", NeighborComparison(digit, arr));
        }
        static bool NeighborComparison(int index, int[] array)
        {
            bool isBigger = false;
            if (index == 0)
            {
                if (array[0] > array[1])
                {
                    isBigger = true;
                }
            }
            else if (index == array.Length - 1)
            {
                if (array[index] > array[array.Length - 1])
                {
                    isBigger = true;
                }
            }
            else if (index != 0 && index < array.Length)
            {
                if (array[index] > array[index - 1] && array[index] > array[index + 1])
                {
                    isBigger = true;
                }
            }
            return isBigger;
        }
    }
}
