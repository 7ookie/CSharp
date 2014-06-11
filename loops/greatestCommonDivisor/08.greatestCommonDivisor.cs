using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace greatestCommonDivisor
{
    class greatestCommonDivisor
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integers to find the greatest common divisor.\nfirst = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("second = ");
            int z = int.Parse(Console.ReadLine());
            while (n != 0 && z != 0)
             {
                 if (n > z)
                 {
                     n %= z;
                 }
                 else
                 {
                     z %= n;
                 }
             }

            if (n == 0)
            {
                Console.WriteLine("The greatest common divisor is: " + z);
            }
            else
            {
                Console.WriteLine("The greatest common divisor is: " + n);
            }
        }
    }
}
