using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compareTwoCharArrays
{
    class compareTwoCharArrays
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            char[] array = one.ToCharArray();
            char[] arr = two.ToCharArray();
            while (arr.Length != array.Length)
            {
                if (arr.Length != array.Length)
                {
                    if (arr.Length > array.Length)
                    {
                        Console.WriteLine("The first array is before second array lexicographically.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The second array is before first array lexicographically.");
                        break;
                    }
                }
            }
            if (array.Length == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (array[i] == arr[i])
                    {
                        Console.WriteLine("The two arrays are equal.");
                        break;
                    }
                    if (array[i] > arr[i])
                    {
                        Console.WriteLine("The first array is before second array lexicographically.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The second array is before first array lexicographically.");
                        break;
                    }
                }
            }
        }
    }
}
