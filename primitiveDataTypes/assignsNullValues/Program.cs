using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignsNullValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("Result: {0}, {1}", a, b);
            a = 33;
            b = 55.5;
            Console.WriteLine("Result: {0}, {1}", a, b);
        }
    }
}
