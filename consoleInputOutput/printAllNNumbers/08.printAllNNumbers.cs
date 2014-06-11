using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printAllNNumbers
{
    class printAllNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Print \"n\" numbers.\nn = ");
            int n = int.Parse(Console.ReadLine());
            for (int z = 1; z <= n; z++)
            {
                Console.WriteLine(z);
            }
        }
    }
}
