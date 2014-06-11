using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exchangeBits
{
    class exchangeBits
    {
        static void Main(string[] args)
        {
            int num = 666;
            Console.WriteLine(num);
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(26, '0'));
            int mask = 7;
            int getBits345 = (7 << 3) & num;
            int getBits242526 = (7 << 24) & num;
            getBits345 = getBits345 << 21;
            getBits242526 = getBits242526 >> 21;
            num = num & (~(mask << 3));
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(26, '0'));
            num = num & (~(mask << 24));
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(26, '0'));
            num = num | getBits345;
            Console.WriteLine(Convert.ToString(num, 2));
            num = num | getBits242526;
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
