using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calcTrailingZeros
{
    class calcTrailingZeros
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer to print how many trailing zeros got in \"N!\".\nN = ");
            int n = int.Parse(Console.ReadLine());
            int sumZeros = 0;
            for (int i = 1; i <= n; i++)
            {
                int divider = i;
                while ((divider % 5) == 0)
                {
                    sumZeros = sumZeros + 1;
                    divider = divider / 5;
                }
            }
            Console.WriteLine("Trailing zeros in N!: " + sumZeros);
        }
    }
}
