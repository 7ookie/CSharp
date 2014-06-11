using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extractBitFromInteger
{
    class extractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer. \ni = ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Input integer. \nBit = ");
            int bit = int.Parse(Console.ReadLine());
            byte z = 1;
            int mask = z << bit;
            Console.WriteLine((i & mask) != 0 ? 1 : 0);
        }
    }
}
