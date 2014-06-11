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
            Console.Write("Quadratic equation calculator. Enter needed values.\na = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double discr = (b * b - 4 * a * c);
            Console.Write("Discriminant d = {0}\n", discr);
            if (discr > 0) //((discr > 0) && (c != 0))
            {
                Console.Write("Real root x1 = {0}\n", ((-b - Math.Sqrt(discr)) / (2 * a)));
                Console.Write("Real root x2 = {0}\n", ((-b + Math.Sqrt(discr)) / (2 * a)));
            }
            else if (discr == 0)
            {
                Console.Write("Real root x = {0}\n", - (b / (2 * a)));
            }
            /*
            else if (c == 0)
            {
                Console.Write("Real root x = {0}\n", ((-1) * (b / a)));
            }
            */
            else
            {
                Console.WriteLine("There are no real roots.");
            }
        }
    }
}
