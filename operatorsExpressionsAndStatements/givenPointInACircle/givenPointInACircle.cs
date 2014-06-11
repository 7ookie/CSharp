using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace givenPointInACircle
{
    class givenPointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Input value for x coordinate x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input value for y coordinate y = ");
            double y = double.Parse(Console.ReadLine());
            bool check = (((x*x) + (y*y)) <= (5*5));
            Console.WriteLine("Is the point within the circle? {0}", check);
        }
    }
}
