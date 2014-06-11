using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace calcNthCatalanNumber
{
    class calcNthCatalanNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer to calculate Nth Catalan number.\nInteger = ");
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Nth Catalan number is: {0}", (CalcFactorial(2 * num)) / (CalcFactorial(num + 1) * CalcFactorial(num)));
        }
        static BigInteger CalcFactorial(BigInteger num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
