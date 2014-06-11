using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace sumOfFibonacciNumbers
{
    class sumOfFibonacciNumbers
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter integer to sum \"n\" Fibonacci numbers.\nn = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger fibonacci = 1;
            BigInteger temp = 0;
            BigInteger sum = 0;
            if (n > 2)
            {
                for (int i = 3; i <= n; i++)
                {
                    fibonacci = fibonacci + temp;
                    temp = fibonacci - temp;
                    sum += fibonacci;
                }
                Console.WriteLine("The sum of Fibonacci numbers is: {0}", sum + 1);
            }
            else if (n == 0 || n == 1)
            {
                Console.WriteLine("The sum of Fibonacci numbers is: 0");
            }
            else if (n == 2)
            {
                Console.WriteLine("The sum of Fibonacci numbers is: 1");
            }
        }
    }
}
