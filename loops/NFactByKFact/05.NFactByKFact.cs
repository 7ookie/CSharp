using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace NFactByKFact
{
    class NFactByKFact
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integer numbers (1<N<K).\nN = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            int g = (k - n);
            BigInteger factorialG = 1;
            if (1 < n && n < k)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int s = 1; s <= k; s++)
                {
                    factorialK *= s;
                }
                for (int e = 1; e <= g; e++)
                {
                    factorialG *= e;
                }
                Console.WriteLine("(N!*K!)/(K-N)! = {0}", ((factorialN * factorialK) / g));
            }
            else
            {
                Console.WriteLine("Do not satisfy the conditions. Try again.");
            }
        }
    }
}
