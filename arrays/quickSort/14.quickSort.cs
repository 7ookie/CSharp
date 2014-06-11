using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quickSort
{
    class quickSort
    {
        static void Main(string[] args)
        {
            string[] array = { "z", "e", "x", "c", "m", "q", "a", "o", "w", "s", "y" };
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array with \"Quick sort algorithm\".");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void QuickSort(string[] arr, int left, int right)
        {
            int a = left;
            int z = right;
            string pivot = arr[(left + right) / 2];
            while(a <= z)
            {
                while (arr[a].CompareTo(pivot) < 0)
                {
                    a++;
                }
                while (arr[z].CompareTo(pivot) > 0)
                {
                    z--;
                }
                if (a <= z)
                {
                    string tmp = arr[a];
                    arr[a] = arr[z];
                    arr[z] = tmp;
                    a++;
                    z--;
                }
            }
            if (left < z)
            {
                QuickSort(arr, left, z);
            }
            if (a < right)
            {
                QuickSort(arr, a, right);
            }
        }
    }   
}
