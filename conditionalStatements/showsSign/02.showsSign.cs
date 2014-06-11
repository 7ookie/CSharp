using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace showsSign
{
    class showsSign
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three signed integer variables and see what is the result sign.\nvariable one = ");
            double varOne = double.Parse(Console.ReadLine());
            Console.Write("variable two = ");
            double varTwo = double.Parse(Console.ReadLine());
            Console.Write("variable three = ");
            double varThree = double.Parse(Console.ReadLine());
            if (varOne >= 0 && varTwo >= 0 && varThree >= 0)
            {
                Console.WriteLine("The sign is: +");
            }
            else if ((varOne >= 0 && varTwo < 0 && varThree < 0) || 
                     (varOne < 0 && varTwo >= 0 && varThree < 0) ||
                     (varOne < 0 && varTwo < 0 && varThree >= 0))
            {
                Console.WriteLine("The sign is: +");
            }
            else
            {
                Console.WriteLine("The sign is: -");
            }
        }
    }
}
