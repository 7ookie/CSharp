using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exchangeIntegerValues
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            byte c = a;
            a = b;
            b = c;
            Console.WriteLine("{0}, {1} ", a, b);
        }
    }
}
