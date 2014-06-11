using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace divideTwoFactorials
{
    class divideTwoFactorials
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integer numbers (1<K<N).\nN = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            if (1 < k && k < n)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int s = 1; s <= k; s++)
                {
                    factorialK *= s;
                }
                Console.WriteLine("N!/K! = {0}", factorialN/factorialK);
            }
            else
            {
                Console.WriteLine("Do not satisfy the conditions. Try again.");
            }
        }
    }
}
