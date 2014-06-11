using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quadraticEquation
{
    class quadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers to solve quadratic equation.\na = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double d = ((b * b) - (4 * a * c));
            if (d < 0)
            {
                Console.WriteLine("The equation haven't real roots.");
            }
            else if (d == 0)
            {
                Console.WriteLine("The equation have a real root: {0}", ((-b) / (2 * a)));
            }
            else
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("The equation have two reals roors:\nx1 = {0}\nx2 = {1}\n", x1, x2);
            }
        }
    }
}
