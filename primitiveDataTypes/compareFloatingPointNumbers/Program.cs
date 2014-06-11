using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compareFloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.000001;
            double b = 0.00000145;
            double r = Math.Round(a, 6);
            double h = Math.Round(b, 6);
            if (r == h)
            {
                bool c = true;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
