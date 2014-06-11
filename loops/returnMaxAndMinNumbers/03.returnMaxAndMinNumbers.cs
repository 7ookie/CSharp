using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace returnMaxAndMinNumbers
{
    class returnMaxAndMinNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers will you input.\nn = ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the numbers.");
            ulong[] array = new ulong[n];
            for (ulong i = 0; i < n; i++)
            {
                Console.Write(i + ": ");
                array[i] = ulong.Parse(Console.ReadLine());
            }
            Console.WriteLine("The min number is {0}.", array.Min());
            Console.WriteLine("The max number is {0}.", array.Max());
        }
    }
}
