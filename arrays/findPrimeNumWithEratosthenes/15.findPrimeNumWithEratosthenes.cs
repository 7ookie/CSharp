using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace findPrimeNumWithEratosthenes
{
    class findPrimeNumWithEratosthenes
    {
        static void Main(string[] args)
        {
            bool[] array = new bool[10000000];
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == false)
                {
                    for (int z = i * i; z < array.Length; z += i)
                    {
                        array[z] = true;
                    } 
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
