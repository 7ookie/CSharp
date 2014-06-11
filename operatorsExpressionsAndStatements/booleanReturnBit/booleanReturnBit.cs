using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booleanReturnBit
{
    class booleanReturnBit
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer. \nNumber = ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Input integer. \nBit possition = ");
            int bitPosition = int.Parse(Console.ReadLine());
            byte z = 1;
            int mask = z << bitPosition;
            Console.WriteLine((num & mask) != 0 ? 1 : 0);
        }
    }
}
