using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculateRectangleArea
{
    class calculateRectangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input values to calculate rectangle area");
            Console.Write("Width = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height = ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle area is: " + (width * height));
        }
    }
}
