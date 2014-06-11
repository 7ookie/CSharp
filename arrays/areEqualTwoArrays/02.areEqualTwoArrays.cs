using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace areEqualTwoArrays
{
    class areEqualTwoArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number to set first array lenght.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number to set second array lenght.");
            int s = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array one = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[s];
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write("Array two = ");
                arr[z] = int.Parse(Console.ReadLine());
            }
            //Array.Sort(arr);
            //Array.Sort(array);
            bool equal = false;
            /*
            bool areEqual = array.SequenceEqual(arr);
            if (array.Length == arr.Length)
            {
                if (areEqual == true)
                {
                    equal = true;
                }
            }
            Console.WriteLine("The arrays are equal. {0}", equal);
            */
            if (array.Length == arr.Length)
            {
                for (int c = 0; c < array.Length; c++)
                {
                    if (array[c] == arr[c])
                    {
                        equal = true;
                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
            }
            Console.WriteLine("The arrays are equal. {0}", equal);
        }
    }
}
