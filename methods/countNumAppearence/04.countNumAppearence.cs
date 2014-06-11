using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace countNumAppearence
{
    class countNumAppearence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer.\ninteger: ");
            int digit = int.Parse(Console.ReadLine());
            int[] arr = {1, 5, 7, 9, 2, 6, 1, 3, 3, 3, 5, 5, 5, 5};
            Console.WriteLine("This number apears in the array: {0} times.", CountNumAppear(digit, arr));
        }
        static int CountNumAppear(int number, params int[] array)
        {
            int frequency = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    frequency++;
                }
            }
            return frequency;
        }
    }
}
