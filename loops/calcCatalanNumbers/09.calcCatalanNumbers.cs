using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace calcCatalanNumbers
{
    class calcCatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer to calculate Catalan's formula where n>=0.\ninteger = ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            BigInteger nByTwo = 1;
            BigInteger plusOne = 1;
            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                for (int s = 1; s <= (n * 2); s++)
                {
                    nByTwo *= s;
                }
                for (int a = 1; a <= (n + 1); a++)
                {
                    plusOne *= a;
                }
                Console.WriteLine("Catalan number \n\"C = (2*n)!/((n+1)!*n!)\" = {0}", (nByTwo / (plusOne * factorial)));
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }
    }
}
