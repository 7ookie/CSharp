using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generateAllNKVariations
{
    class generateAllNKVariations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer value for \"n\".\nn = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter integer value for \"k\".\nk = ");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            Variations(array, 0, n);
        }
        static void Variations(int[] array, int index, int n)
        {
            if (index == array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int z = 1; z <= n; z++)
                {
                    array[index] = z;
                    Variations(array, index + 1, n);
                }
            }
        }
    }
}
