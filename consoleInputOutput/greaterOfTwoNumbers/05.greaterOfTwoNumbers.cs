using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace greaterOfTwoNumbers
{
    class greaterOfTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers and find whitch is bigger.\na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Bigger = " + Math.Max(a, b));
        }
    }
}
