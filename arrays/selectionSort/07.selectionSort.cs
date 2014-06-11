using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace selectionSort
{
    class selectionSort
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
            int min = 0;
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = i;
                for (int s = i + 1; s < array.Length; s++)
                {
                    if (array[s] < array[min])
                    {
                        min = s;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            Console.WriteLine("Sorted array with \"Selection sort algorithm\":");
            foreach (int var in array)
            {
                Console.WriteLine(var);
            }
        }
    }
}
