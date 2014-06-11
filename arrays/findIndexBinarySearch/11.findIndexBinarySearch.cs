using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace findIndexBinarySearch
{
    class findIndexBinarySearch
    {   
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter integer number to set array lenght.");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8};
            Console.Write("Enter array element to find it's index.\nelement = ");
            int z = int.Parse(Console.ReadLine());
            int index = Array.BinarySearch(array, z);
            Console.WriteLine("The index of \"{0}th\" element is: {1}", z, index);
            */
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = 3;
            Console.WriteLine(BnrSearch(array, index));
        }
        public static int BnrSearch(int[] array, int index)
        {
            Array.Sort(array);
            int min = 0;
            int max = array.Length - 1;
            int middle;
            while (max >= min)
            {
                middle = (min + max) / 2;
                if (array[middle] == index)
                {
                    return middle;
                }
                if (array[middle] < index)
                {
                    min = middle + 1;
                }
                if (array[middle] > index)
                {
                    max = middle - 1;
                }
            }
            return -1;
        }
    }
}
