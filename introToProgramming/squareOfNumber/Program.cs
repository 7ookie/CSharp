using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace squareOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Square of the number 12345 is: " + (12345*12345));
            Console.WriteLine("The Square of the number 12345 is: {0}", Math.Pow(12345, 2));
        }
    }
}
