using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumOfThreeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer three integer numbers to find their sum.\na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of a,b and c is: " + (a+b+c));
        }
    }
}
