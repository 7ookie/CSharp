using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circleAreaNPerimeter
{
    class circleAreaNPerimeter
    {
        static void Main(string[] args)
        {
            Console.Write("Input circle radius.\nradius = ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The circle area is: {0}, the perimeter is: {1}", 
                (3.14159265359 * (radius * radius)), (3.14159265359 * (radius * 2)));
        }
    }
}
