using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumOfNNumbers
{
    class sumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for n to calculate the sum from zero to n.\nn = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int z = 1; z <= n; z++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
