using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace returnMaximaElement
{
    class returnMaximaElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer 0 <= number <= 8 include! \nnumber = ");
            int num = int.Parse(Console.ReadLine());
            int[] array = { 1, 145, 5, 6, 7, 10, 1, 5, 3 };
            Console.WriteLine("The biggest number in this array portion is: {0}", FindBiggest(num, array));
            Console.WriteLine();
            Console.WriteLine("Array in ascending order: ");
            foreach (var item in ArraySortAsc(array))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Array in descending order: ");
            foreach (var item in ArraySortDesc(array))
            {
                Console.WriteLine(item);
            }
        }
        static int[] ArraySortAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int z = i; z < array.Length; z++)
                {
                    if (array[z] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[z];
                        array[z] = temp;
                    }
                }
            }
            return array;
        }
        static int[] ArraySortDesc(int[] array)
        {
            /*
            var sortDesc = array.OrderByDescending(a => a);
            foreach (int item in sortDesc)
            {
                Console.WriteLine(item);
            }
            */
            for (int i = 0; i < array.Length; i++)
            {
                for (int z = i; z < array.Length; z++)
                {
                    if (array[z] > array[i])
                    {
                        int temp = array[i];
                        array[i] = array[z];
                        array[z] = temp;
                    }
                }
            }
            return array;
        }
        static int FindBiggest(int number, int[] arr)
        {
            int lenght = arr.Length - 1;
            int temp = 0;
            int biggest = 0;
            if (number > lenght)
            {
                return -1;
            }
            if (number == lenght)
            {
                biggest = arr[lenght];
            }
            else
            {
                for (int i = number; i < lenght; i++)
                {
                    temp = arr[i + 1];
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                    }
                    if (biggest < temp)
                    {
                        biggest = temp;
                    }
                }
            }
            return biggest;
        }
    }
}
