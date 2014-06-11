using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printNNumbers
{
    class printNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter \"n\" to print the numbers from 1 to \"n\".\nn = ");
            int num = int.Parse(Console.ReadLine());
            for (int z = 1; z <= num; z++)
            {
                Console.WriteLine(z);
            }
        }
    }
}
