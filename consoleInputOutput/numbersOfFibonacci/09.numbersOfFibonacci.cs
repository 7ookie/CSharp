using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace numbersOfFibonacci
{
    class numbersOfFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the first 100 members of Fibonacci.");
            Console.WriteLine("0");
            BigInteger a = 0;
            BigInteger s = 1;
            for (int z = 0; z <= 100; z++)
            {
                BigInteger temp = a;
                a = s;
                s = s + temp;
                Console.WriteLine(a);
            }
        }
    }
}
