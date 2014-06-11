using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pointInCircleNRectangle
{
    class pointInCircleNRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Check for given point is it within a circle and out of the rectangle.\nx = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool checkCircle = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 9;
            bool checkRectangle = (((x > -1) && (x < 5)) && ((y > -1) && (y < 1)));
            if (checkCircle == true && checkRectangle == false)
            {
                Console.WriteLine("The given point is within a circle and out of the rectangle.");
            }
        }
    }
}
