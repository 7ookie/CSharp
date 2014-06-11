using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myAgeAfterTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your age: ");
            byte n = byte.Parse(Console.ReadLine());
            Console.Write("Your age after years will be: {0}", (n + 10));
            Console.WriteLine();
        }
    }
}
