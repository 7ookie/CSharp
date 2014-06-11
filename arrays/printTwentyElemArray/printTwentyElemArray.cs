using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printTwentyElemArray
{
    class arrayIndexByFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 20 integer numbers to fill the array.");
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("integer = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Print twenty array elements.");
            for (int z = 0; z < array.Length; z++)
            {
                Console.WriteLine(z + " - " + (array[z]));
            }
        }
    }
}
