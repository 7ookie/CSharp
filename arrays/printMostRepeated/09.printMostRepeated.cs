using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printMostRepeated
{
    class printMostRepeated
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number to set array lenght.");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            var number = (from item in array group item by item into g orderby g.Count() descending select g.Key).First();
            var frequency = (from item in array group item by item into g orderby g.Count() descending select g.Count()).First();
            Console.WriteLine("Number \"{0}\" is in array \"{1}\" times.", number, frequency);
        }
    }
}
