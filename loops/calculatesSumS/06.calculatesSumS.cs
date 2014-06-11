using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculatesSumS
{
    class calculatesSumS
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer.\nx = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input power for \"x\".\nn = ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            decimal power = 0;
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power = (decimal)Math.Pow(x, i);
                sum += (factorial / power);
            }
            Console.WriteLine(1+sum);
        }
    }
}
