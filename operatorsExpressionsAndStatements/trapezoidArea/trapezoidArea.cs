using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trapezoidArea
{
    class trapezoidArea
    {
        static void Main(string[] args)
        {
            Console.Write("Input values to calculate trapezoid's area. \nSide a = ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Side b = ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Altitude h = ");
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid area is: " + (((sideA+sideB)/2)*altitude));
        }
    }
}
