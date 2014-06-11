using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace calculateFactorial
{
    class calculateFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number. 1 <= number <= 100 \nnumber = ");
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Wrong input.");
            }
            Console.WriteLine("The result of {0}! to 100! is: {1}", num, Factorial(num));
        }
        static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for (int i = number; i <= 100; i++)
            {
                number = i;
                result *= number;
            }
            return result;
        }
    }
}
