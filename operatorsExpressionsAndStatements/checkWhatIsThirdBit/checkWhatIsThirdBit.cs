using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace checkWhatIsThirdBit
{
    class checkWhatIsThirdBit
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int num = int.Parse(Console.ReadLine()); 
            int bitPosition = 3;
            int mask = 1 << bitPosition;
            int result = num & mask;
            result = result >> bitPosition;
            Console.WriteLine(result);
        }
    }
}
